using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;

using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Superres;
using Emgu.CV.Util;
using System.Text.RegularExpressions;

namespace openCV_secondApp
{
    public partial class Form1 : Form
    {
        bool stopAcq=false;
        Mat cap1 = new Mat();
        Mat cap2 = new Mat();
        Mat FrameOrig = new Mat();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartCam_Click(object sender, EventArgs e)
        {
            startCam();
        }

        private void startCam()
        {
            stopAcq = false;
            VideoCapture capture = new VideoCapture(0);
            //Application.Idle += ProcessFrame;
            capture.Start();
            cap1 = capture.QueryFrame();
            //CvInvoke.CvtColor(capture.QueryFrame(), Frame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            
            
            capture.ImageGrabbed += (sender,e) =>  frameUpdated(sender, e, capture); // Lambda expression
            // to pass the parameter to the event handler
        }

        private void frameUpdated(object sender, EventArgs e, VideoCapture capture)
        {
            if (!stopAcq)
            {
                cap2 = capture.QueryFrame();
                Bitmap bmp = cap1.ToBitmap();
                
                Bitmap motionImg=motionDetect(cap1, cap2);
                updatePicBox(cap2.ToBitmap(), picBxCam);


                cap1 = cap2;
            }
            else
            {
                capture.Stop(); 
            }
            

        }
        public void updatePicBox(Bitmap img, PictureBox picBx)
        {
            if (chkBxFlip.CheckState == CheckState.Checked)
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);

            picBx.Image = img;
            picBx.SizeMode = PictureBoxSizeMode.Zoom;

        }


        public Bitmap motionDetect(Mat Frame, Mat Frame2)
        {
            Mat FrameDummy = Frame;
            Mat Frame2Dummy = Frame2;
            try
            {
                CvInvoke.CvtColor(Frame, FrameDummy, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            }
            catch(CvException e) { }
            CvInvoke.GaussianBlur(FrameDummy, FrameDummy, new Size(21, 21), 0);
            
            try
            {
                CvInvoke.CvtColor(Frame2Dummy, Frame2, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            }
            catch { }
            CvInvoke.GaussianBlur(Frame2Dummy, Frame2Dummy, new Size(21, 21), 0);

            Mat Difference1 = new Mat();
            CvInvoke.AbsDiff(FrameDummy, Frame2Dummy, Difference1);
            //Previous_Frame = Frame;
            
            Mat Thr = new Mat();
            CvInvoke.Threshold(Difference1, Thr, 25, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            //CvInvoke.Dilate(Thr, Thr, 0);
            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hierarchy = new Mat();
            Mat ThrDup = Thr;
            CvInvoke.FindContours(ThrDup, contours, hierarchy, Emgu.CV.CvEnum.RetrType.Tree, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            CvInvoke.DrawContours(Frame2, contours, -1, new MCvScalar(100, 100, 0));




            return Frame2.ToBitmap();

        }

        private void btnStopCam_Click(object sender, EventArgs e)
        {
            stopAcq = true;
        }
    }
}

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
using System.Runtime.Remoting.Messaging;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using Emgu.CV.Cuda;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing.Imaging;

namespace openCV_secondApp
{
    public partial class Form2 : Form
    {
        Mat prevImage;
        Mat currentImage;
        int count = 0;
        VideoCapture capture;
        double motionThreshold = 35;
        bool saveImage;
        int camNum;
        int rotateVal = 0;
        bool etch = false;
        Stopwatch stopWatch = new Stopwatch();
        bool useMotion = true;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            trackBar1.Value = (int)motionThreshold;
            //saveImage = Convert.ToBoolean(chkBxSaveImage.CheckState);
            //txtBxSavePath.Text = Properties.Settings.Default.savePath;
            cmbBxCamNum.SelectedIndex = 0;

            rotateVal = Properties.Settings.Default.rotateVal;
        }

       
        public void runCam()
        {
            capture = new VideoCapture(camNum);
            prevImage = new Mat();
            capture.ImageGrabbed += imageGrabbed;
            capture.Start();
            // to pass the parameter to the event handler
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //txtBxSavePath.Enabled = false;
            runCam();
        }
        private void imageGrabbed(object sender, EventArgs e)
        {
            // Set Status to Idle
            //lblStatus.Text = "Idle"; lblStatus.ForeColor= System.Drawing.Color.Black;
            

            currentImage=capture.QueryFrame();

            Mat showImage = (Mat)currentImage.Clone();

            Mat Frame = prevImage;
            Mat Frame2= (Mat)currentImage.Clone();

            Mat FrameDummy = Frame;
            Mat Frame2Dummy = Frame2;
            try
            {
                CvInvoke.CvtColor(Frame, FrameDummy, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            }
            catch (CvException ex) {
                prevImage = currentImage;
                return ;
            }
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
            
            CvInvoke.Threshold(Difference1, Thr, motionThreshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            //CvInvoke.Dilate(Thr, Thr, 0);
            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hierarchy = new Mat();
            Mat ThrDup = Thr;
            CvInvoke.FindContours(ThrDup, contours, hierarchy, Emgu.CV.CvEnum.RetrType.Tree, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            
            if (contours.Length > 0)
            {
                
                onDetection();
            }
            else
            {
                ThreadHelperClass.SetText(this, lblStatus, "No Motion!");
            }
            CvInvoke.DrawContours(showImage, contours, -1, new MCvScalar(100, 100, 0));


            // Save the Image

            //ThreadHelperClass.SetText(this, lblStatus, contours.Length.ToString());
            //lblStatus.Text = contours.Length.ToString();

            prevImage = currentImage;

            Bitmap SHOWIMG = showImage.ToBitmap();
            

            pictureBox1.Image = rotateImage(SHOWIMG);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            



        }

        public void onDetection()
        {
            ThreadHelperClass.SetText(this, lblStatus, "Motion Detected!");
            //if (saveImage && txtBxSavePath.Text!="")
            //{
            //    saveImageFun(rotateImage(currentImage.ToBitmap()), txtBxSavePath.Text);
            //}
            stopEtching();
        }

        public void saveImageFun(Bitmap img, string BasePath)
        {
            //if (flipVert)
            //{
            //    img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            //}
            string savePath = BasePath + "/";
            savePath = savePath + DateTime.Now.ToString("yyyy/MM/dd") + "/";
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
            string saveName = savePath + DateTime.Now.ToString("HH-mm-ss")+".jpg";
            img.Save(saveName, ImageFormat.Jpeg);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            stopCapture();
        }
        public void stopCapture()
        {
            if (capture is  null)
            {
                
            }
            else
            {
                if (capture.IsOpened)
                {
                    capture.Stop();
                    //txtBxSavePath.Enabled = true;
                    pictureBox1.Image = new Mat().ToBitmap();
                    lblStatus.Text = "Idle";
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void txtBxTracBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            txtBxTracBar.Text = trackBar1.Value.ToString();
            motionThreshold = trackBar1.Value;
        }

        private void txtBxTracBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                try
                {
                    trackBar1.Value = int.Parse(txtBxTracBar.Text);
                }
                catch { }
            }
        }

        private void chkBxSaveImage_CheckedChanged(object sender, EventArgs e)
        {
            //saveImage=Convert.ToBoolean(chkBxSaveImage.CheckState);
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            //MessageBox.Show(DateTime.Now.ToString("hh-mm-ss") + " : " + DateTime.Now.ToString("yyyy/MM/dd"));
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                //Do your work here!
                //txtBxSavePath.Text = folderName;
            }
        }

        private void txtBxSavePath_TextChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.savePath = txtBxSavePath.Text;
            Properties.Settings.Default.Save();
        }

        private void cmbBxCamNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            stopCapture();
            camNum = cmbBxCamNum.SelectedIndex;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About showAbout = new About();
            showAbout.ShowDialog(); 
        }

        private void chkBxFlipVertical_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            start_timer();
        }

        void deleteOldFolders()
        {
            //string basePath = txtBxSavePath.Text;
            //string[] folders = Directory.GetDirectories(basePath);
            string str = "";
            //foreach (string folderPath in folders)
            //{
            //    str = str+ folderPath + ", ";
            //    //folderName = folderPath.Split("\\").Last(); 
            //}
            //MessageBox.Show(str);
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (rotateVal < 3)
            {
                rotateVal = rotateVal + 1;
            }
            else
            {
                rotateVal = 0;
            }

            Properties.Settings.Default.rotateVal = rotateVal;
            Properties.Settings.Default.Save();
        }

        public Bitmap rotateImage(Bitmap image)
        {

            if (rotateVal == 0)
            { }

            if (rotateVal == 1)
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            if (rotateVal == 2)
                image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            if (rotateVal == 3)
                image.RotateFlip(RotateFlipType.Rotate270FlipNone);


            return image;
        }

        private void btnStartEtch_Click(object sender, EventArgs e)
        {
            start_etching();
        }
        public void start_etching()
        {
            if (!etch)
            {
                if (sendtoRelay("1"))
                {
                    etch = true;
                    start_timer();
                    
                }
            }

        }

        public bool sendtoRelay(string state)
        {
            if (comboSerial1.com.IsOpen)
            {
                comboSerial1.sendSerial(state);
                return true;
            } 
            return false;
        }
        public void stopEtching()
        {
            if (etch)
            {
                if (sendtoRelay("0"))
                {
                    etch = false;
                    stop_timer();
                }
            }
        }

        public void start_timer()
        {
            stopWatch.Start();
            timer_etching.Start();
            lblCurrentEtchingState.Text = "Etching.";
            lblCurrentEtchingState.ForeColor = Color.Red;
        }
        public void stop_timer()
        {
            timer_etching.Stop();
            stopWatch.Stop();
            lblCurrentEtchingState.Text = "Not Etching.";
            lblCurrentEtchingState.ForeColor = Color.Green;
        }
        public void reset_timer()
        {
            lblEtchingStat.Text = "Etching Status: 0";
            stopWatch.Reset();
            stopWatch.Start();
        }

        private void btnStopEtch_Click(object sender, EventArgs e)
        {
            stopEtching();
        }

        private void btnResetEtch_Click(object sender, EventArgs e)
        {
            reset_timer();

        }

        private void timer_etching_Tick(object sender, EventArgs e)
        {
            lblEtchingStat.Text = "Etching Time : " + ((int)(stopWatch.ElapsedMilliseconds/100)/10).ToString() + " s";
        }

        private void chkBxUsecMotion_CheckedChanged(object sender, EventArgs e)
        {
            chkBxUsecMotion.Checked = useMotion;
        }

        private void debug2_Click(object sender, EventArgs e)
        {
            reset_timer();
            
        }

        private void debug3_Click(object sender, EventArgs e)
        {
            stop_timer();
        }
    }
}

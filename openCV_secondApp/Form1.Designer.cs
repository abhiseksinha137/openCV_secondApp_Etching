namespace openCV_secondApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartCam = new System.Windows.Forms.Button();
            this.picBxCam = new System.Windows.Forms.PictureBox();
            this.btnStopCam = new System.Windows.Forms.Button();
            this.chkBxFlip = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartCam
            // 
            this.btnStartCam.Location = new System.Drawing.Point(12, 12);
            this.btnStartCam.Name = "btnStartCam";
            this.btnStartCam.Size = new System.Drawing.Size(96, 23);
            this.btnStartCam.TabIndex = 0;
            this.btnStartCam.Text = "Start Camera";
            this.btnStartCam.UseVisualStyleBackColor = true;
            this.btnStartCam.Click += new System.EventHandler(this.btnStartCam_Click);
            // 
            // picBxCam
            // 
            this.picBxCam.Location = new System.Drawing.Point(12, 51);
            this.picBxCam.Name = "picBxCam";
            this.picBxCam.Size = new System.Drawing.Size(786, 387);
            this.picBxCam.TabIndex = 1;
            this.picBxCam.TabStop = false;
            // 
            // btnStopCam
            // 
            this.btnStopCam.Location = new System.Drawing.Point(127, 12);
            this.btnStopCam.Name = "btnStopCam";
            this.btnStopCam.Size = new System.Drawing.Size(96, 23);
            this.btnStopCam.TabIndex = 0;
            this.btnStopCam.Text = "Stop Camera";
            this.btnStopCam.UseVisualStyleBackColor = true;
            this.btnStopCam.Click += new System.EventHandler(this.btnStopCam_Click);
            // 
            // chkBxFlip
            // 
            this.chkBxFlip.AutoSize = true;
            this.chkBxFlip.Checked = true;
            this.chkBxFlip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxFlip.Location = new System.Drawing.Point(253, 16);
            this.chkBxFlip.Name = "chkBxFlip";
            this.chkBxFlip.Size = new System.Drawing.Size(101, 17);
            this.chkBxFlip.TabIndex = 2;
            this.chkBxFlip.Text = "Flip Horizontallly";
            this.chkBxFlip.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkBxFlip);
            this.Controls.Add(this.picBxCam);
            this.Controls.Add(this.btnStopCam);
            this.Controls.Add(this.btnStartCam);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBxCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartCam;
        private System.Windows.Forms.PictureBox picBxCam;
        private System.Windows.Forms.Button btnStopCam;
        private System.Windows.Forms.CheckBox chkBxFlip;
    }
}


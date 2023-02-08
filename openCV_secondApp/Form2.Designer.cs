namespace openCV_secondApp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnStart = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtBxTracBar = new System.Windows.Forms.TextBox();
            this.cmbBxCamNum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStartEtch = new System.Windows.Forms.Button();
            this.btnStopEtch = new System.Windows.Forms.Button();
            this.btnResetEtch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBxUsecMotion = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEtchingStat = new System.Windows.Forms.Label();
            this.timer_etching = new System.Windows.Forms.Timer(this.components);
            this.comboSerial1 = new customControl.comboSerial();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Cam";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(119, 18);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop Cam";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sensitivity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(789, 6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(24, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Idle";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(64, 75);
            this.trackBar1.Maximum = 150;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(88, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // txtBxTracBar
            // 
            this.txtBxTracBar.Location = new System.Drawing.Point(152, 77);
            this.txtBxTracBar.Name = "txtBxTracBar";
            this.txtBxTracBar.Size = new System.Drawing.Size(42, 20);
            this.txtBxTracBar.TabIndex = 7;
            this.txtBxTracBar.TextChanged += new System.EventHandler(this.txtBxTracBar_TextChanged);
            this.txtBxTracBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxTracBar_KeyDown);
            // 
            // cmbBxCamNum
            // 
            this.cmbBxCamNum.FormattingEnabled = true;
            this.cmbBxCamNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbBxCamNum.Location = new System.Drawing.Point(73, 48);
            this.cmbBxCamNum.Name = "cmbBxCamNum";
            this.cmbBxCamNum.Size = new System.Drawing.Size(24, 21);
            this.cmbBxCamNum.TabIndex = 12;
            this.cmbBxCamNum.SelectedIndexChanged += new System.EventHandler(this.cmbBxCamNum_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cam Num";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(861, 96);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(826, 73);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(70, 23);
            this.btnDebug.TabIndex = 17;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.BackgroundImage = global::openCV_secondApp.Properties.Resources.Rotate;
            this.btnRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRotate.Location = new System.Drawing.Point(119, 48);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(22, 21);
            this.btnRotate.TabIndex = 18;
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(896, 525);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnStartEtch
            // 
            this.btnStartEtch.Location = new System.Drawing.Point(6, 19);
            this.btnStartEtch.Name = "btnStartEtch";
            this.btnStartEtch.Size = new System.Drawing.Size(75, 23);
            this.btnStartEtch.TabIndex = 19;
            this.btnStartEtch.Text = "Start";
            this.btnStartEtch.UseVisualStyleBackColor = true;
            this.btnStartEtch.Click += new System.EventHandler(this.btnStartEtch_Click);
            // 
            // btnStopEtch
            // 
            this.btnStopEtch.Location = new System.Drawing.Point(6, 50);
            this.btnStopEtch.Name = "btnStopEtch";
            this.btnStopEtch.Size = new System.Drawing.Size(75, 23);
            this.btnStopEtch.TabIndex = 19;
            this.btnStopEtch.Text = "Stop";
            this.btnStopEtch.UseVisualStyleBackColor = true;
            this.btnStopEtch.Click += new System.EventHandler(this.btnStopEtch_Click);
            // 
            // btnResetEtch
            // 
            this.btnResetEtch.Location = new System.Drawing.Point(103, 50);
            this.btnResetEtch.Name = "btnResetEtch";
            this.btnResetEtch.Size = new System.Drawing.Size(75, 23);
            this.btnResetEtch.TabIndex = 19;
            this.btnResetEtch.Text = "Reset";
            this.btnResetEtch.UseVisualStyleBackColor = true;
            this.btnResetEtch.Click += new System.EventHandler(this.btnResetEtch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEtchingStat);
            this.groupBox1.Controls.Add(this.chkBxUsecMotion);
            this.groupBox1.Controls.Add(this.btnStartEtch);
            this.groupBox1.Controls.Add(this.btnResetEtch);
            this.groupBox1.Controls.Add(this.btnStopEtch);
            this.groupBox1.Location = new System.Drawing.Point(463, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 103);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etching Relay";
            // 
            // chkBxUsecMotion
            // 
            this.chkBxUsecMotion.AutoSize = true;
            this.chkBxUsecMotion.Checked = true;
            this.chkBxUsecMotion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxUsecMotion.Location = new System.Drawing.Point(103, 20);
            this.chkBxUsecMotion.Name = "chkBxUsecMotion";
            this.chkBxUsecMotion.Size = new System.Drawing.Size(80, 17);
            this.chkBxUsecMotion.TabIndex = 20;
            this.chkBxUsecMotion.Text = "Use Motion";
            this.chkBxUsecMotion.UseVisualStyleBackColor = true;
            this.chkBxUsecMotion.CheckedChanged += new System.EventHandler(this.chkBxUsecMotion_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.stop);
            this.groupBox2.Controls.Add(this.btnRotate);
            this.groupBox2.Controls.Add(this.cmbBxCamNum);
            this.groupBox2.Controls.Add(this.txtBxTracBar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera Control";
            // 
            // lblEtchingStat
            // 
            this.lblEtchingStat.AutoSize = true;
            this.lblEtchingStat.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtchingStat.Location = new System.Drawing.Point(6, 82);
            this.lblEtchingStat.Name = "lblEtchingStat";
            this.lblEtchingStat.Size = new System.Drawing.Size(108, 16);
            this.lblEtchingStat.TabIndex = 22;
            this.lblEtchingStat.Text = "Etching Status";
            // 
            // timer_etching
            // 
            this.timer_etching.Tick += new System.EventHandler(this.timer_etching_Tick);
            // 
            // comboSerial1
            // 
            this.comboSerial1.Location = new System.Drawing.Point(354, 12);
            this.comboSerial1.Name = "comboSerial1";
            this.comboSerial1.Size = new System.Drawing.Size(103, 94);
            this.comboSerial1.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 637);
            this.Controls.Add(this.comboSerial1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "MotionDetection";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txtBxTracBar;
        private System.Windows.Forms.ComboBox cmbBxCamNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnStartEtch;
        private System.Windows.Forms.Button btnStopEtch;
        private System.Windows.Forms.Button btnResetEtch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEtchingStat;
        private System.Windows.Forms.CheckBox chkBxUsecMotion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer_etching;
        private customControl.comboSerial comboSerial1;
    }
}
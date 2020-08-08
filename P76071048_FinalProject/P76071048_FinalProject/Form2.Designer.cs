namespace P76071048_FinalProject
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
            this.FormSwitchTo1 = new System.Windows.Forms.Button();
            this.ShowFramePictureBox = new System.Windows.Forms.PictureBox();
            this.VideoStartButton = new System.Windows.Forms.Button();
            this.VideoStopButton = new System.Windows.Forms.Button();
            this.FrameTimer = new System.Windows.Forms.Timer(this.components);
            this.VideoModeGroupBox = new System.Windows.Forms.GroupBox();
            this.VideoRegularRB = new System.Windows.Forms.RadioButton();
            this.VideoBilateralRB = new System.Windows.Forms.RadioButton();
            this.VideoCannyRB = new System.Windows.Forms.RadioButton();
            this.VideoGrayRB = new System.Windows.Forms.RadioButton();
            this.VideoSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.VideoRecordButton = new System.Windows.Forms.Button();
            this.VideoEndRecordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowFramePictureBox)).BeginInit();
            this.VideoModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormSwitchTo1
            // 
            this.FormSwitchTo1.Location = new System.Drawing.Point(537, 537);
            this.FormSwitchTo1.Name = "FormSwitchTo1";
            this.FormSwitchTo1.Size = new System.Drawing.Size(110, 25);
            this.FormSwitchTo1.TabIndex = 0;
            this.FormSwitchTo1.Text = "切換到圖片編輯";
            this.FormSwitchTo1.UseVisualStyleBackColor = true;
            this.FormSwitchTo1.Click += new System.EventHandler(this.FormSwitchTo1_Click);
            // 
            // ShowFramePictureBox
            // 
            this.ShowFramePictureBox.Location = new System.Drawing.Point(1, 1);
            this.ShowFramePictureBox.Name = "ShowFramePictureBox";
            this.ShowFramePictureBox.Size = new System.Drawing.Size(100, 50);
            this.ShowFramePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ShowFramePictureBox.TabIndex = 1;
            this.ShowFramePictureBox.TabStop = false;
            // 
            // VideoStartButton
            // 
            this.VideoStartButton.Location = new System.Drawing.Point(1, 507);
            this.VideoStartButton.Name = "VideoStartButton";
            this.VideoStartButton.Size = new System.Drawing.Size(80, 25);
            this.VideoStartButton.TabIndex = 2;
            this.VideoStartButton.Text = "Start Camera";
            this.VideoStartButton.UseVisualStyleBackColor = true;
            this.VideoStartButton.Click += new System.EventHandler(this.StartVideoButton_Click);
            // 
            // VideoStopButton
            // 
            this.VideoStopButton.Location = new System.Drawing.Point(1, 537);
            this.VideoStopButton.Name = "VideoStopButton";
            this.VideoStopButton.Size = new System.Drawing.Size(80, 25);
            this.VideoStopButton.TabIndex = 3;
            this.VideoStopButton.Text = "Stop Camera";
            this.VideoStopButton.UseVisualStyleBackColor = true;
            this.VideoStopButton.Click += new System.EventHandler(this.CloseVideoButton_Click);
            // 
            // FrameTimer
            // 
            this.FrameTimer.Interval = 50;
            this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
            // 
            // VideoModeGroupBox
            // 
            this.VideoModeGroupBox.Controls.Add(this.VideoRegularRB);
            this.VideoModeGroupBox.Controls.Add(this.VideoBilateralRB);
            this.VideoModeGroupBox.Controls.Add(this.VideoCannyRB);
            this.VideoModeGroupBox.Controls.Add(this.VideoGrayRB);
            this.VideoModeGroupBox.Location = new System.Drawing.Point(169, 525);
            this.VideoModeGroupBox.Name = "VideoModeGroupBox";
            this.VideoModeGroupBox.Size = new System.Drawing.Size(362, 37);
            this.VideoModeGroupBox.TabIndex = 4;
            this.VideoModeGroupBox.TabStop = false;
            this.VideoModeGroupBox.Text = "Mode";
            // 
            // VideoRegularRB
            // 
            this.VideoRegularRB.AutoSize = true;
            this.VideoRegularRB.Location = new System.Drawing.Point(285, 16);
            this.VideoRegularRB.Name = "VideoRegularRB";
            this.VideoRegularRB.Size = new System.Drawing.Size(71, 16);
            this.VideoRegularRB.TabIndex = 3;
            this.VideoRegularRB.TabStop = true;
            this.VideoRegularRB.Text = "正常模式";
            this.VideoRegularRB.UseVisualStyleBackColor = true;
            // 
            // VideoBilateralRB
            // 
            this.VideoBilateralRB.AutoSize = true;
            this.VideoBilateralRB.Location = new System.Drawing.Point(184, 16);
            this.VideoBilateralRB.Name = "VideoBilateralRB";
            this.VideoBilateralRB.Size = new System.Drawing.Size(95, 16);
            this.VideoBilateralRB.TabIndex = 2;
            this.VideoBilateralRB.TabStop = true;
            this.VideoBilateralRB.Text = "影像平滑模式";
            this.VideoBilateralRB.UseVisualStyleBackColor = true;
            // 
            // VideoCannyRB
            // 
            this.VideoCannyRB.AutoSize = true;
            this.VideoCannyRB.Location = new System.Drawing.Point(83, 16);
            this.VideoCannyRB.Name = "VideoCannyRB";
            this.VideoCannyRB.Size = new System.Drawing.Size(95, 16);
            this.VideoCannyRB.TabIndex = 1;
            this.VideoCannyRB.TabStop = true;
            this.VideoCannyRB.Text = "圖像邊緣模式";
            this.VideoCannyRB.UseVisualStyleBackColor = true;
            // 
            // VideoGrayRB
            // 
            this.VideoGrayRB.AutoSize = true;
            this.VideoGrayRB.Location = new System.Drawing.Point(6, 16);
            this.VideoGrayRB.Name = "VideoGrayRB";
            this.VideoGrayRB.Size = new System.Drawing.Size(71, 16);
            this.VideoGrayRB.TabIndex = 0;
            this.VideoGrayRB.TabStop = true;
            this.VideoGrayRB.Text = "灰階模式";
            this.VideoGrayRB.UseVisualStyleBackColor = true;
            // 
            // VideoRecordButton
            // 
            this.VideoRecordButton.Location = new System.Drawing.Point(88, 509);
            this.VideoRecordButton.Name = "VideoRecordButton";
            this.VideoRecordButton.Size = new System.Drawing.Size(75, 23);
            this.VideoRecordButton.TabIndex = 5;
            this.VideoRecordButton.Text = "開始錄製";
            this.VideoRecordButton.UseVisualStyleBackColor = true;
            this.VideoRecordButton.Click += new System.EventHandler(this.VideoRecordButton_Click);
            // 
            // VideoEndRecordButton
            // 
            this.VideoEndRecordButton.Location = new System.Drawing.Point(88, 537);
            this.VideoEndRecordButton.Name = "VideoEndRecordButton";
            this.VideoEndRecordButton.Size = new System.Drawing.Size(75, 23);
            this.VideoEndRecordButton.TabIndex = 6;
            this.VideoEndRecordButton.Text = "結束錄製";
            this.VideoEndRecordButton.UseVisualStyleBackColor = true;
            this.VideoEndRecordButton.Click += new System.EventHandler(this.VideoEndRecordButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 562);
            this.Controls.Add(this.VideoEndRecordButton);
            this.Controls.Add(this.VideoRecordButton);
            this.Controls.Add(this.VideoModeGroupBox);
            this.Controls.Add(this.VideoStopButton);
            this.Controls.Add(this.VideoStartButton);
            this.Controls.Add(this.ShowFramePictureBox);
            this.Controls.Add(this.FormSwitchTo1);
            this.Name = "Form2";
            this.Text = "VideoShow";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowFramePictureBox)).EndInit();
            this.VideoModeGroupBox.ResumeLayout(false);
            this.VideoModeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FormSwitchTo1;
        private System.Windows.Forms.PictureBox ShowFramePictureBox;
        private System.Windows.Forms.Button VideoStartButton;
        private System.Windows.Forms.Button VideoStopButton;
        private System.Windows.Forms.Timer FrameTimer;
        private System.Windows.Forms.GroupBox VideoModeGroupBox;
        private System.Windows.Forms.RadioButton VideoBilateralRB;
        private System.Windows.Forms.RadioButton VideoCannyRB;
        private System.Windows.Forms.RadioButton VideoGrayRB;
        private System.Windows.Forms.RadioButton VideoRegularRB;
        private System.Windows.Forms.SaveFileDialog VideoSaveFileDialog;
        private System.Windows.Forms.Button VideoRecordButton;
        private System.Windows.Forms.Button VideoEndRecordButton;
    }
}
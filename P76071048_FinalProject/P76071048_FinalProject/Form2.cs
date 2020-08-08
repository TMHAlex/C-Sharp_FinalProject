using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace P76071048_FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();            
        }

        Mat videoSrc = new Mat();
        bool setOnOff = false;
        FrameSource frame = Cv2.CreateFrameSource_Camera(0);
        VideoWriter videoWrite = new VideoWriter();
        bool SaveFlag = false;
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            VideoSaveFileDialog.Filter = "Image Files(*.avi)|*.avi|All files (*.*)|*.*";
            VideoSaveFileDialog.Title = "Saving Video";
        }

        private void FormSwitchTo1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 f1 = new Form1();
            f1.Show();            
        }

        private void StartVideoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("攝影機打開", "開啟", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrameTimer.Start();            
        }

        private void CloseVideoButton_Click(object sender, EventArgs e)
        {
            FrameTimer.Stop();
            MessageBox.Show("攝影機關閉", "關閉", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            frame.NextFrame(videoSrc);
            Cv2.Flip(videoSrc, videoSrc, FlipMode.Y);
            if(VideoGrayRB.Checked == true)
            {
                Cv2.CvtColor(videoSrc, videoSrc, ColorConversionCodes.BGR2GRAY);
            }
            else if(VideoCannyRB.Checked == true)
            {
                Cv2.CvtColor(videoSrc, videoSrc, ColorConversionCodes.BGR2GRAY);
                Cv2.Canny(videoSrc, videoSrc, 50, 200);
            }
            else if(VideoBilateralRB.Checked == true)
            {
                Mat videoDstTemp = new Mat();
                Cv2.BilateralFilter(videoSrc, videoDstTemp, 9, 50, 50);
                videoSrc = videoDstTemp.Clone();
            }
            if(SaveFlag == true)
            {
                if(videoSrc.Channels() == 1)
                {
                    Cv2.CvtColor(videoSrc, videoSrc, ColorConversionCodes.GRAY2BGR);
                }
                videoWrite.Write(videoSrc);
            }
            Bitmap srcbitmap = videoSrc.ToBitmap();
            ShowFramePictureBox.Image = srcbitmap;
        }

        private void VideoRecordButton_Click(object sender, EventArgs e)
        {
            if (VideoSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SaveFlag = true;
                videoWrite = new VideoWriter(VideoSaveFileDialog.FileName, FourCC.XVID, 10, new OpenCvSharp.Size(videoSrc.Cols, videoSrc.Rows), true);
            }          
        }

        private void VideoEndRecordButton_Click(object sender, EventArgs e)
        {
            SaveFlag = false;
            MessageBox.Show("錄製完成", "錄製完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

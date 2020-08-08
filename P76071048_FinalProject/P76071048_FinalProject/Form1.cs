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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mat src = new Mat();
        String picPath;
        Mat[] srcOprator = new Mat[10];
        int srcOpreatorStep = -1;
        int stepFlag = -1;

        private void StepControl()
        {
            if(srcOpreatorStep<stepFlag)
            {
                if(stepFlag!=9)
                {
                    stepFlag++;
                    srcOpreatorStep = stepFlag;
                    srcOprator[srcOpreatorStep] = src.Clone();                   
                }
                else
                {
                    for (int i = 0; i < stepFlag; i++)
                    {
                        srcOprator[i] = srcOprator[i + 1];
                    }
                    srcOprator[stepFlag] = src.Clone();
                    srcOpreatorStep = stepFlag;
                }
                //label1.Text = srcOpreatorStep.ToString() + "   " + stepFlag.ToString();
            }
            else
            {
                if (srcOpreatorStep < 9)
                {
                    srcOpreatorStep++;
                    stepFlag++;
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                    {
                        srcOprator[i] = srcOprator[i + 1];
                    }
                }
                srcOprator[srcOpreatorStep] = src.Clone();
                //label1.Text = srcOpreatorStep.ToString() + "   " + stepFlag.ToString();
            }                
        }

        private void ShowTheInformation()
        {
            InfoLabel.Text = "*The picture information*" + "\n\n" + "Path = " + picPath + "\n"
                        + "Height = " + src.Rows.ToString() + "        " + "Width = " + src.Cols.ToString() + "\n"
                        + "Channels = " + src.Channels().ToString() + "        " + "Depth = " + src.Depth();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            OpenPicDialog.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            OpenPicDialog.Title = "Loading Picture";
            SavePicDialog.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            SavePicDialog.Title = "Saving Picture";
        }       

        private void LoadPicture_Click(object sender, EventArgs e)
        {           
            if (OpenPicDialog.ShowDialog() == DialogResult.OK && OpenPicDialog.FileName != null)
            {
                try
                {
                    src = Cv2.ImRead(OpenPicDialog.FileName, ImreadModes.AnyColor);
                    Bitmap srcbitmap = src.ToBitmap();
                    ShowPictureBox.Image = srcbitmap;
                    picPath = OpenPicDialog.FileName;
                    ShowTheInformation();
                    StepControl();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("請選取適當格式的圖檔", "注意");
                }
            }          
        }

        private void SavePicture_Click(object sender, EventArgs e)
        {
            Bitmap srcbitmap = src.ToBitmap();
            srcbitmap.Save(picPath, System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("Save Completed", "Successed");
        }
        private void SaveAnotherPicture_Click(object sender, EventArgs e)
        {
            Bitmap srcbitmap = src.ToBitmap();
            if (SavePicDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && SavePicDialog.FileName != "")
            {
                /*switch (SavePicDialog.FilterIndex)
                {
                    case 1:
                        srcbitmap.Save(SavePicDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;

                    case 2:
                        srcbitmap.Save(SavePicDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 3:
                        srcbitmap.Save(SavePicDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 4:
                        srcbitmap.Save(SavePicDialog.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }*/
                srcbitmap.Save(SavePicDialog.FileName);
                string savePath = SavePicDialog.FileName;
                string fileNameExt = savePath.Substring(savePath.LastIndexOf("\\") + 1/*, savePath.LastIndexOf(".") - savePath.LastIndexOf("\\") - 1*/);
                MessageBox.Show("New file " + fileNameExt + " Save Completed", "Successed");
            }
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            if(srcOpreatorStep<stepFlag)
            {
                StepControl();
            }
            Cv2.Flip(src, src, FlipMode.Y);
            Bitmap srcbitmap = src.ToBitmap();
            ShowPictureBox.Image = srcbitmap;
            ShowTheInformation();
            StepControl();
        }

        private void FlipButton2_Click(object sender, EventArgs e)
        {
            if (srcOpreatorStep < stepFlag)
            {
                StepControl();
            }
            Cv2.Flip(src, src, FlipMode.X);
            Bitmap srcbitmap = src.ToBitmap();
            ShowPictureBox.Image = srcbitmap;
            ShowTheInformation();
            StepControl();
        }        

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "編輯") //若按編輯主功能項目
            {
                if(srcOpreatorStep>0)
                {UpStep.Enabled = true;}
                else
                {UpStep.Enabled = false;}
                if(srcOpreatorStep<stepFlag)
                {NextStep.Enabled = true;}
                else
                {NextStep.Enabled = false;}
            }
            else if (e.ClickedItem.ToString() == "工具")
            {
                if (srcOpreatorStep >= 0)
                {GrayValueMode.Enabled = true;}
                else
                {GrayValueMode.Enabled = false;}
                if (srcOpreatorStep >= 0)
                {EqualizeMode.Enabled = true;}
                else
                {EqualizeMode.Enabled = false;}
                if (srcOpreatorStep >= 0)
                { CannyMode.Enabled = true; }
                else
                { CannyMode.Enabled = false; }
                if (srcOpreatorStep >= 0)
                { BilateralMode.Enabled = true; }
                else
                { BilateralMode.Enabled = false; }
            }
        }

        private void UpStep_Click(object sender, EventArgs e)
        {
            srcOpreatorStep--;
            //label1.Text = srcOpreatorStep.ToString() + "   " + stepFlag.ToString();
            src = srcOprator[srcOpreatorStep].Clone();
            Bitmap srcbitmap = src.ToBitmap();
            ShowPictureBox.Image = srcbitmap;
            ShowTheInformation();
        }

        private void NextStep_Click(object sender, EventArgs e)
        {
            srcOpreatorStep++;
            //label1.Text = srcOpreatorStep.ToString() + "   " + stepFlag.ToString();
            src = srcOprator[srcOpreatorStep].Clone();
            Bitmap srcbitmap = src.ToBitmap();
            ShowPictureBox.Image = srcbitmap;
            ShowTheInformation();
        }

        private void GrayValueMode_Click(object sender, EventArgs e)
        {
            try
            {
                if (srcOpreatorStep < stepFlag)
                {
                    StepControl();
                }
                Cv2.CvtColor(src, src, ColorConversionCodes.BGR2GRAY);
                Bitmap srcbitmap = src.ToBitmap();
                ShowPictureBox.Image = srcbitmap;
                ShowTheInformation();
                StepControl();
            }          
            catch (Exception ex)
            {
                MessageBox.Show("此圖片已經是灰階圖模式", "注意");
            }
        }

        private void HDRMode_Click(object sender, EventArgs e)
        {
            if(src.Channels()==3)
            {
                if (srcOpreatorStep < stepFlag)
                {
                    StepControl();
                }
                Mat[] bgr = new Mat[3];
                Cv2.Split(src, out bgr);
                Cv2.EqualizeHist(bgr[0], bgr[0]);
                Cv2.EqualizeHist(bgr[1], bgr[1]);
                Cv2.EqualizeHist(bgr[2], bgr[2]);
                Cv2.Merge(bgr, src);
                Bitmap srcbitmap = src.ToBitmap();
                ShowPictureBox.Image = srcbitmap;
                ShowTheInformation();
                StepControl();
            }
            else if(src.Channels()==1)
            {
                if (srcOpreatorStep < stepFlag)
                {
                    StepControl();
                }
                Cv2.EqualizeHist(src, src);
                Bitmap srcbitmap = src.ToBitmap();
                ShowPictureBox.Image = srcbitmap;
                ShowTheInformation();
                StepControl();
            }
        }

        private void CannyMode_Click(object sender, EventArgs e)
        {           
            if (srcOpreatorStep < stepFlag)
            {
                StepControl();
            }
            if (src.Channels() == 3)
            {
                Cv2.CvtColor(src, src, ColorConversionCodes.BGR2GRAY);
            }
            Cv2.Canny(src, src, 50, 200);
            Bitmap srcbitmap = src.ToBitmap();
            ShowPictureBox.Image = srcbitmap;
            ShowTheInformation();
            StepControl();
        }

        private void BilateralMode_Click(object sender, EventArgs e)
        {
            try
            {
                if (srcOpreatorStep < stepFlag)
                {
                    StepControl();
                }
                Mat dstTemp = new Mat();
                Cv2.BilateralFilter(src, dstTemp, 9, 50, 50);
                src = dstTemp.Clone();
                Bitmap srcbitmap = src.ToBitmap();
                ShowPictureBox.Image = srcbitmap;
                ShowTheInformation();
                StepControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Picture", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (srcOpreatorStep < stepFlag)
                {
                    StepControl();
                }
                int InputRows = 0, InputCols = 0;
                InputRows = int.Parse(RowsTextBox.Text);
                InputCols = int.Parse(ColsTextBox.Text);
                Cv2.Resize(src, src, new OpenCvSharp.Size(InputCols, InputRows), 0, 0, InterpolationFlags.Linear);
                Bitmap srcbitmap = src.ToBitmap();
                ShowPictureBox.Image = srcbitmap;
                ShowTheInformation();
                StepControl();
                RowsTextBox.Text = "";
                ColsTextBox.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please input the height and width would you like to change", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RowsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                {
                    MessageBox.Show("Please input numbers 0-9", "False Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                }
            }
        }

        private void ColsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                {
                    MessageBox.Show("Please input numbers 0-9", "False Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                }
            }
        }

        private void AngleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != '-')
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                {
                    MessageBox.Show("Please input numbers", "False Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                }
            }
        }

        private void RotationButton_Click(object sender, EventArgs e)
        {
            try
            {
                int InputAngle = 0;
                InputAngle = int.Parse(AngleTextBox.Text);
                if((InputAngle >= -360) && (InputAngle <= 360))
                {
                    if (srcOpreatorStep < stepFlag)
                    {
                        StepControl();
                    }
                    OpenCvSharp.Point center = new OpenCvSharp.Point(src.Cols / 2, src.Rows / 2);
                    Mat rot_mat = Cv2.GetRotationMatrix2D(center, InputAngle, 1);
                    Cv2.WarpAffine(src, src, rot_mat, src.Size());
                    Bitmap srcbitmap = src.ToBitmap();
                    ShowPictureBox.Image = srcbitmap;
                    ShowTheInformation();
                    StepControl();
                    AngleTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Please input the angle between (-360) ~ (360)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please input the angle would you like", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void FormSwitchTo2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();           
        }       
    }
}

namespace P76071048_FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePicture = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAnotherPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpStep = new System.Windows.Forms.ToolStripMenuItem();
            this.NextStep = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrayValueMode = new System.Windows.Forms.ToolStripMenuItem();
            this.EqualizeMode = new System.Windows.Forms.ToolStripMenuItem();
            this.CannyMode = new System.Windows.Forms.ToolStripMenuItem();
            this.BilateralMode = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPicDialog = new System.Windows.Forms.OpenFileDialog();
            this.SavePicDialog = new System.Windows.Forms.SaveFileDialog();
            this.ShowPictureBox = new System.Windows.Forms.PictureBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.RotationGroupBox = new System.Windows.Forms.GroupBox();
            this.FlipButton2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DegreeLabel = new System.Windows.Forms.Label();
            this.AngleTextBox = new System.Windows.Forms.TextBox();
            this.AngleLabel = new System.Windows.Forms.Label();
            this.RotationButton = new System.Windows.Forms.Button();
            this.FlipButton = new System.Windows.Forms.Button();
            this.ZoomGroupBox = new System.Windows.Forms.GroupBox();
            this.ColsTextBox = new System.Windows.Forms.TextBox();
            this.RowsTextBox = new System.Windows.Forms.TextBox();
            this.ColsLabel = new System.Windows.Forms.Label();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.ZoomButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FormSwitchTo2 = new System.Windows.Forms.Button();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPictureBox)).BeginInit();
            this.RotationGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ZoomGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.ToolsMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(684, 24);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            this.MenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadPicture,
            this.SavePicture,
            this.SaveAnotherPicture});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(44, 20);
            this.FileMenuItem.Text = "檔案";
            // 
            // LoadPicture
            // 
            this.LoadPicture.Image = ((System.Drawing.Image)(resources.GetObject("LoadPicture.Image")));
            this.LoadPicture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadPicture.Name = "LoadPicture";
            this.LoadPicture.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.LoadPicture.Size = new System.Drawing.Size(188, 22);
            this.LoadPicture.Text = "開啟圖片(&O)";
            this.LoadPicture.Click += new System.EventHandler(this.LoadPicture_Click);
            // 
            // SavePicture
            // 
            this.SavePicture.Image = ((System.Drawing.Image)(resources.GetObject("SavePicture.Image")));
            this.SavePicture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SavePicture.Name = "SavePicture";
            this.SavePicture.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SavePicture.Size = new System.Drawing.Size(188, 22);
            this.SavePicture.Text = "儲存圖片(&S)";
            this.SavePicture.Click += new System.EventHandler(this.SavePicture_Click);
            // 
            // SaveAnotherPicture
            // 
            this.SaveAnotherPicture.Name = "SaveAnotherPicture";
            this.SaveAnotherPicture.Size = new System.Drawing.Size(188, 22);
            this.SaveAnotherPicture.Text = "另存圖片(&A)";
            this.SaveAnotherPicture.Click += new System.EventHandler(this.SaveAnotherPicture_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpStep,
            this.NextStep});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(44, 20);
            this.EditMenuItem.Text = "編輯";
            // 
            // UpStep
            // 
            this.UpStep.Enabled = false;
            this.UpStep.Name = "UpStep";
            this.UpStep.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UpStep.Size = new System.Drawing.Size(172, 22);
            this.UpStep.Text = "上一步(&U)";
            this.UpStep.Click += new System.EventHandler(this.UpStep_Click);
            // 
            // NextStep
            // 
            this.NextStep.Enabled = false;
            this.NextStep.Name = "NextStep";
            this.NextStep.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.NextStep.Size = new System.Drawing.Size(172, 22);
            this.NextStep.Text = "下一步(&R)";
            this.NextStep.Click += new System.EventHandler(this.NextStep_Click);
            // 
            // ToolsMenuItem
            // 
            this.ToolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GrayValueMode,
            this.EqualizeMode,
            this.CannyMode,
            this.BilateralMode});
            this.ToolsMenuItem.Name = "ToolsMenuItem";
            this.ToolsMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ToolsMenuItem.Text = "工具";
            // 
            // GrayValueMode
            // 
            this.GrayValueMode.Enabled = false;
            this.GrayValueMode.Name = "GrayValueMode";
            this.GrayValueMode.Size = new System.Drawing.Size(168, 22);
            this.GrayValueMode.Text = "灰階圖模式";
            this.GrayValueMode.Click += new System.EventHandler(this.GrayValueMode_Click);
            // 
            // EqualizeMode
            // 
            this.EqualizeMode.Enabled = false;
            this.EqualizeMode.Name = "EqualizeMode";
            this.EqualizeMode.Size = new System.Drawing.Size(168, 22);
            this.EqualizeMode.Text = "直方圖等化";
            this.EqualizeMode.Click += new System.EventHandler(this.HDRMode_Click);
            // 
            // CannyMode
            // 
            this.CannyMode.Enabled = false;
            this.CannyMode.Name = "CannyMode";
            this.CannyMode.Size = new System.Drawing.Size(168, 22);
            this.CannyMode.Text = "邊緣偵測";
            this.CannyMode.Click += new System.EventHandler(this.CannyMode_Click);
            // 
            // BilateralMode
            // 
            this.BilateralMode.Enabled = false;
            this.BilateralMode.Name = "BilateralMode";
            this.BilateralMode.Size = new System.Drawing.Size(168, 22);
            this.BilateralMode.Text = "影像平滑(去雜訊)";
            this.BilateralMode.Click += new System.EventHandler(this.BilateralMode_Click);
            // 
            // ShowPictureBox
            // 
            this.ShowPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ShowPictureBox.Name = "ShowPictureBox";
            this.ShowPictureBox.Size = new System.Drawing.Size(100, 50);
            this.ShowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ShowPictureBox.TabIndex = 1;
            this.ShowPictureBox.TabStop = false;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoLabel.Location = new System.Drawing.Point(0, 630);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(90, 12);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "Information Label";
            // 
            // RotationGroupBox
            // 
            this.RotationGroupBox.Controls.Add(this.FlipButton2);
            this.RotationGroupBox.Controls.Add(this.groupBox1);
            this.RotationGroupBox.Controls.Add(this.FlipButton);
            this.RotationGroupBox.Location = new System.Drawing.Point(564, 27);
            this.RotationGroupBox.Name = "RotationGroupBox";
            this.RotationGroupBox.Size = new System.Drawing.Size(120, 150);
            this.RotationGroupBox.TabIndex = 3;
            this.RotationGroupBox.TabStop = false;
            this.RotationGroupBox.Text = "Rotation";
            // 
            // FlipButton2
            // 
            this.FlipButton2.Location = new System.Drawing.Point(7, 49);
            this.FlipButton2.Name = "FlipButton2";
            this.FlipButton2.Size = new System.Drawing.Size(107, 23);
            this.FlipButton2.TabIndex = 1;
            this.FlipButton2.Text = "Flip-UpDown";
            this.FlipButton2.UseVisualStyleBackColor = true;
            this.FlipButton2.Click += new System.EventHandler(this.FlipButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DegreeLabel);
            this.groupBox1.Controls.Add(this.AngleTextBox);
            this.groupBox1.Controls.Add(this.AngleLabel);
            this.groupBox1.Controls.Add(this.RotationButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // DegreeLabel
            // 
            this.DegreeLabel.AutoSize = true;
            this.DegreeLabel.Location = new System.Drawing.Point(85, 42);
            this.DegreeLabel.Name = "DegreeLabel";
            this.DegreeLabel.Size = new System.Drawing.Size(17, 12);
            this.DegreeLabel.TabIndex = 3;
            this.DegreeLabel.Text = "度";
            // 
            // AngleTextBox
            // 
            this.AngleTextBox.Location = new System.Drawing.Point(42, 39);
            this.AngleTextBox.Name = "AngleTextBox";
            this.AngleTextBox.Size = new System.Drawing.Size(39, 22);
            this.AngleTextBox.TabIndex = 2;
            this.AngleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AngleTextBox_KeyPress);
            // 
            // AngleLabel
            // 
            this.AngleLabel.AutoSize = true;
            this.AngleLabel.Location = new System.Drawing.Point(3, 42);
            this.AngleLabel.Name = "AngleLabel";
            this.AngleLabel.Size = new System.Drawing.Size(33, 12);
            this.AngleLabel.TabIndex = 1;
            this.AngleLabel.Text = "Angle";
            // 
            // RotationButton
            // 
            this.RotationButton.Location = new System.Drawing.Point(2, 10);
            this.RotationButton.Name = "RotationButton";
            this.RotationButton.Size = new System.Drawing.Size(104, 23);
            this.RotationButton.TabIndex = 0;
            this.RotationButton.Text = "Rotate";
            this.RotationButton.UseVisualStyleBackColor = true;
            this.RotationButton.Click += new System.EventHandler(this.RotationButton_Click);
            // 
            // FlipButton
            // 
            this.FlipButton.Location = new System.Drawing.Point(6, 23);
            this.FlipButton.Name = "FlipButton";
            this.FlipButton.Size = new System.Drawing.Size(108, 23);
            this.FlipButton.TabIndex = 0;
            this.FlipButton.Text = "Flip-LeftRight";
            this.FlipButton.UseVisualStyleBackColor = true;
            this.FlipButton.Click += new System.EventHandler(this.FlipButton_Click);
            // 
            // ZoomGroupBox
            // 
            this.ZoomGroupBox.Controls.Add(this.ColsTextBox);
            this.ZoomGroupBox.Controls.Add(this.RowsTextBox);
            this.ZoomGroupBox.Controls.Add(this.ColsLabel);
            this.ZoomGroupBox.Controls.Add(this.RowsLabel);
            this.ZoomGroupBox.Controls.Add(this.ZoomButton);
            this.ZoomGroupBox.Location = new System.Drawing.Point(564, 183);
            this.ZoomGroupBox.Name = "ZoomGroupBox";
            this.ZoomGroupBox.Size = new System.Drawing.Size(120, 125);
            this.ZoomGroupBox.TabIndex = 4;
            this.ZoomGroupBox.TabStop = false;
            this.ZoomGroupBox.Text = "Zoom";
            // 
            // ColsTextBox
            // 
            this.ColsTextBox.Location = new System.Drawing.Point(48, 92);
            this.ColsTextBox.Name = "ColsTextBox";
            this.ColsTextBox.Size = new System.Drawing.Size(61, 22);
            this.ColsTextBox.TabIndex = 5;
            this.ColsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ColsTextBox_KeyPress);
            // 
            // RowsTextBox
            // 
            this.RowsTextBox.Location = new System.Drawing.Point(48, 60);
            this.RowsTextBox.Name = "RowsTextBox";
            this.RowsTextBox.Size = new System.Drawing.Size(61, 22);
            this.RowsTextBox.TabIndex = 4;
            this.RowsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RowsTextBox_KeyPress);
            // 
            // ColsLabel
            // 
            this.ColsLabel.AutoSize = true;
            this.ColsLabel.Location = new System.Drawing.Point(6, 97);
            this.ColsLabel.Name = "ColsLabel";
            this.ColsLabel.Size = new System.Drawing.Size(34, 12);
            this.ColsLabel.TabIndex = 3;
            this.ColsLabel.Text = "Width";
            // 
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(6, 65);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(36, 12);
            this.RowsLabel.TabIndex = 2;
            this.RowsLabel.Text = "Height";
            // 
            // ZoomButton
            // 
            this.ZoomButton.Location = new System.Drawing.Point(7, 22);
            this.ZoomButton.Name = "ZoomButton";
            this.ZoomButton.Size = new System.Drawing.Size(107, 23);
            this.ZoomButton.TabIndex = 0;
            this.ZoomButton.Text = "Zoom-In/Out";
            this.ZoomButton.UseVisualStyleBackColor = true;
            this.ZoomButton.Click += new System.EventHandler(this.ZoomInButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ShowPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 550);
            this.panel1.TabIndex = 5;
            // 
            // FormSwitchTo2
            // 
            this.FormSwitchTo2.Location = new System.Drawing.Point(574, 617);
            this.FormSwitchTo2.Name = "FormSwitchTo2";
            this.FormSwitchTo2.Size = new System.Drawing.Size(110, 25);
            this.FormSwitchTo2.TabIndex = 6;
            this.FormSwitchTo2.Text = "切換到視訊鏡頭";
            this.FormSwitchTo2.UseVisualStyleBackColor = true;
            this.FormSwitchTo2.Click += new System.EventHandler(this.FormSwitchTo2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 642);
            this.Controls.Add(this.FormSwitchTo2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ZoomGroupBox);
            this.Controls.Add(this.RotationGroupBox);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "Form1";
            this.Text = "OpenCvSharpApplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPictureBox)).EndInit();
            this.RotationGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ZoomGroupBox.ResumeLayout(false);
            this.ZoomGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadPicture;
        private System.Windows.Forms.ToolStripMenuItem SavePicture;
        private System.Windows.Forms.ToolStripMenuItem SaveAnotherPicture;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpStep;
        private System.Windows.Forms.ToolStripMenuItem NextStep;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenPicDialog;
        private System.Windows.Forms.SaveFileDialog SavePicDialog;
        private System.Windows.Forms.PictureBox ShowPictureBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.GroupBox RotationGroupBox;
        private System.Windows.Forms.Button FlipButton;
        private System.Windows.Forms.Button FlipButton2;
        private System.Windows.Forms.ToolStripMenuItem GrayValueMode;
        private System.Windows.Forms.ToolStripMenuItem EqualizeMode;
        private System.Windows.Forms.ToolStripMenuItem CannyMode;
        private System.Windows.Forms.GroupBox ZoomGroupBox;
        private System.Windows.Forms.Button ZoomButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.Label ColsLabel;
        private System.Windows.Forms.TextBox ColsTextBox;
        private System.Windows.Forms.TextBox RowsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AngleTextBox;
        private System.Windows.Forms.Label AngleLabel;
        private System.Windows.Forms.Button RotationButton;
        private System.Windows.Forms.ToolStripMenuItem BilateralMode;
        private System.Windows.Forms.Label DegreeLabel;
        private System.Windows.Forms.Button FormSwitchTo2;
    }
}


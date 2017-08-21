namespace CamWinApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnGetPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point(26, 80);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(313, 232);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(26, 13);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(212, 20);
            this.comboBox.TabIndex = 1;
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(245, 13);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 2;
            this.btnCon.Text = "连接";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnGetPhoto
            // 
            this.btnGetPhoto.Location = new System.Drawing.Point(341, 12);
            this.btnGetPhoto.Name = "btnGetPhoto";
            this.btnGetPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnGetPhoto.TabIndex = 3;
            this.btnGetPhoto.Text = "拍照";
            this.btnGetPhoto.UseVisualStyleBackColor = true;
            this.btnGetPhoto.Click += new System.EventHandler(this.btnGetPhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(366, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGetPhoto);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.videoSourcePlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnGetPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


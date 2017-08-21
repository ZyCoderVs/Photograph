using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Controls;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;

namespace CamWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private FilterInfoCollection filterInfoCollections { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollections = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (filterInfoCollections.Count == 0)
            {
                MessageBox.Show("未检测到摄像装备");
            }
            foreach (FilterInfo item in filterInfoCollections)
            {
                comboBox.Items.Add(item.Name);
            }
            this.comboBox.SelectedIndex = 0;
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (videoSourcePlayer.IsRunning)
            {
                MessageBox.Show("摄像装备已打开！！！");
                return;
            }
            FilterInfo info = filterInfoCollections[comboBox.SelectedIndex];
            VideoCaptureDevice vcd = new VideoCaptureDevice(info.MonikerString);
            this.videoSourcePlayer.VideoSource = vcd;
            this.videoSourcePlayer.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.videoSourcePlayer.SignalToStop();
            this.videoSourcePlayer.WaitForStop();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {
        }

        private void btnGetPhoto_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!this.videoSourcePlayer.IsRunning)
                {
                    MessageBox.Show("未检测到有摄像装置在运行");
                    return;
                }
                Bitmap bitmap = this.videoSourcePlayer.GetCurrentVideoFrame();
                string fileName = Guid.NewGuid().ToString() + ".jpeg";
                string dir = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)+DateTime.Now.ToString("yyyy-MM-dd");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                this.pictureBox1.Image = bitmap;
                string newPath = Path.Combine(dir,fileName);
                bitmap.Save(newPath,ImageFormat.Jpeg);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

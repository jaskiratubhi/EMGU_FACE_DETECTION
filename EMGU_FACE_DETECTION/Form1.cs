using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;

namespace EMGU_FACE_DETECTION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        int xval = 0;
        int yval=0;

        private void Form1_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
            {
                camDevice.Items.Add(device.Name);
            }
            camDevice.SelectedIndex = 0;
            device = new VideoCaptureDevice();

        }

        private void BtnDetect_Click(object sender, EventArgs e)
        {
            device = new VideoCaptureDevice(filter[camDevice.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
        }
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");
        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> greyImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(greyImage,1.2,5);
            if (rectangles.Length > 0)
            {
                xval = rectangles[0].X + rectangles[0].Width / 2;
                yval = rectangles[0].Y + rectangles[0].Height / 2;
               
            }
            foreach (Rectangle rectangle in rectangles)
            {
                using(Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using(Pen pen=new Pen(Color.Blue, 5))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }
            videoFeed.Image = bitmap;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            txtX.Text = xval.ToString();
            txtY.Text = yval.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
        }
    }
}

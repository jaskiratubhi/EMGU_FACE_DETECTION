using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;

namespace EMGU_FACE_DETECTION
{

    public partial class Form1 : Form
    {
        //Variables
        const int ON = 1;
        const int OFF = 0;
        int motorStatus = OFF;
        bool endstop1Tripped = false;
        bool endstop2Tripped = false;
        //Data packet
        const int START_BYTE = 255;     //byte 1
        int commandByte = 0;            //byte 2
        int dataByteHigh = 0;           //byte 3 
        int dataByteLow = 0;            //byte 4
        int endByte = 0;                //byte 5
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            //Set trackbar details
            verticalPositionBar.Maximum = 100;
            verticalPositionBar.TickFrequency = 1;
            verticalPositionBar.LargeChange = 5;
            verticalPositionBar.SmallChange = 1;
            verticalPositionBar.Value = 0;
            horizontalPositionBar.Maximum = 100;
            horizontalPositionBar.TickFrequency = 1;
            horizontalPositionBar.LargeChange = 5;
            horizontalPositionBar.SmallChange = 1;
            horizontalPositionBar.Value = 50;
        }
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        int xval = 0;
        int yval=0;

        private void Form1_Load(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            COMPORTbox.DataSource = ports;

            //Video filtering
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
            motorStatus = OFF;
            //Turn off solenoid
            sendMotorCommand();
            serialPort1.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Update ports
            var ports = SerialPort.GetPortNames();
            COMPORTbox.DataSource = ports;

            //Update XY value display
            txtX.Text = xval.ToString();
            txtY.Text = yval.ToString();

            //Update endstop information
            rotationEndStopTxt.Text = endstop1Tripped.ToString();
            verticalEndStopTxt.Text = endstop2Tripped.ToString();
            //Display X and Y coordinates
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
        }

        private void BtnCOMConnect_Click(object sender, EventArgs e)
        {
            try //if the COM port disappears between initialization and click
            {
                //Connect if no ports are opened
                if (!serialPort1.IsOpen)
                {
                    string portID = COMPORTbox.SelectedValue.ToString();
                    serialPort1.PortName = portID;
                    serialPort1.Open();
                    btnCOMConnect.Text = "Disconnect";
                    bool keepGoing = true;
                }
                else
                {
                    //Disconnect if port is opened
                    serialPort1.Close();
                    btnCOMConnect.Text = "Connect";
                }
            }
            catch (Exception myError)
            {
                MessageBox.Show(myError.ToString());
            }
        }

        private void MotorONbtn_Click(object sender, EventArgs e)
        {
            //ON command to motors
            motorStatus = ON;
            sendMotorCommand();
        }

        private void MotorOFFbtn_Click(object sender, EventArgs e)
        {
            //OFF command to motors
            motorStatus = OFF;
            sendMotorCommand();
        }

        private void sendMotorCommand()
        {
            if (motorStatus == ON)
            {
                byte[] TxBytes = new Byte[5];
                TxBytes[0] = Convert.ToByte(START_BYTE);
                TxBytes[1] = Convert.ToByte(commandByte);
                TxBytes[2] = Convert.ToByte(dataByteHigh);
                TxBytes[3] = Convert.ToByte(dataByteLow);
                TxBytes[4] = Convert.ToByte(endByte);

                //Sends command packet to serial port
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(TxBytes, 0, 1);
                    Thread.Sleep(10);
                    serialPort1.Write(TxBytes, 1, 1);
                    Thread.Sleep(10);
                    serialPort1.Write(TxBytes, 2, 1);
                    Thread.Sleep(10);
                    serialPort1.Write(TxBytes, 3, 1);
                    Thread.Sleep(10);
                    serialPort1.Write(TxBytes, 4, 1);
                    Thread.Sleep(10);
                }
            }
        }

        private void FireLeftbtn_Click(object sender, EventArgs e)
        {
            //Fire left solenoid
        }

        private void FireRightbtn_Click(object sender, EventArgs e)
        {
            //Fire right solenoid
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            //Send home command
        }
    }
}

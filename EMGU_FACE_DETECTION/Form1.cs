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
using System.Collections.Concurrent;
using System.Drawing;
namespace EMGU_FACE_DETECTION
{

    public partial class Form1 : Form
    {
        //Variables
        const int ON = 1;
        const int OFF = 0;
        const int Xcenter = 300;
        const int Ycenter = 200;
        //commands
        //Motor 1 = rotation.   Motor 2 = up/down

        const int M1LEFT = 1;   //Motor 1, left
        const int M1RIGHT = 3;  //Motor 1, right
        const int M2UP = 2;     //Motor 2, up
        const int M2DOWN = 4;   //Motor 2, down
        const int FIRELEFTSOLENOID = 5;     //Fire Left Solenoid
        const int FIRERIGHTSOLENOID = 6;    //Fire Right Solenoid
        const int M1STOPPED = 7;   //Motor 1 on but stopped
        const int M2STOPPED = 8;   //Motor 2 on but stopped
        const int MOTORSOFF = 9;  //Emergency Power shutdown(Both Motors)
        const int HOME = 10;
        const int SPEED_THRESHOLD = 20; // Minimum person's speed threshold
        int M1status = OFF;
        int M2status = OFF;
        bool endstop1Tripped = false;
        bool endstop2Tripped = false;
        int verticalValue;
        int horizontalValue;
        // Queue for holding speed of person over time
        ConcurrentQueue<int> speed = new ConcurrentQueue<int>();
        int current_speed;
        int old_distance = 0;
        int frame_count = 0;
        bool timer_flag = false;
        const int FRAME_AVERAGE= 5;
        //Data packet
        // const int START_BYTE = 255;     //byte 1
        // int commandByte = 0;            //byte 2
        //int dataByteHigh = 0;           //byte 3 
        //int dataByteLow = 0;            //byte 4
        //int endByte = 0;                //byte 5
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
            if (frame_count < 1)
            {
                frame_count++;
            }

            else
            {
                frame_count = 0;
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                Image<Bgr, byte> greyImage = new Image<Bgr, byte>(bitmap);
                Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(greyImage, 1.2, 5);
                if (rectangles.Length > 0)
                {
                    xval = rectangles[0].X + rectangles[0].Width / 2;
                    yval = rectangles[0].Y + rectangles[0].Height / 2;

                }
                else if (rectangles.Length == 0)
                {
                    xval = 0;
                    yval = 0;
                    Graphics graphics = Graphics.FromImage(bitmap);
                    Pen pen1 = new Pen(Color.Red, 15);

                    graphics.DrawRectangle(pen1, 10, 10, 100, 50);
                }
                if (rectangles.Length > 1)
                {
                    xval = 0;
                    yval = 0;
                    Graphics graphics = Graphics.FromImage(bitmap);
                    Pen pen1 = new Pen(Color.Green, 15);

                    graphics.DrawRectangle(pen1, 10, 10, 100, 50);

                }
                foreach (Rectangle rectangle in rectangles)
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using (Pen pen = new Pen(Color.Blue, 5))
                        {
                            graphics.DrawRectangle(pen, rectangle);
                        }
                    }
                }
                videoFeed.Image = bitmap;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
            //Turn off solenoid
            sendMotorCommand(MOTORSOFF);
            serialPort1.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int new_distance;
            int data;
            //Update ports
            // var ports = SerialPort.GetPortNames();
            // COMPORTbox.DataSource = ports;

            //Update XY value display
            txtX.Text = xval.ToString();
            txtY.Text = yval.ToString();

            //Update endstop information
            rotationEndStopTxt.Text = endstop1Tripped.ToString();
            verticalEndStopTxt.Text = endstop2Tripped.ToString();
            //Display X and Y coordinates
            verticalValue = verticalPositionBar.Value;
            horizontalValue = horizontalPositionBar.Value;

            //Make movement decisions
            if (xval > 0)
            {
                if (xval > Xcenter + 30)
                {
                    M1status = ON;
                    M2status = ON;
                    sendMotorCommand(1);
                }
                else if (xval <= Xcenter - 30)
                {
                    M1status = ON;
                    M2status = ON;
                    sendMotorCommand(3);
                }
                else
                {
                    M1status = ON;
                    M2status = ON;
                    sendMotorCommand(9);
                }
            }
            //Y movements
            if (yval > 0)
            {
                if (yval < Ycenter - 10)
                {
                    M1status = ON;
                    M2status = ON;
                    sendMotorCommand(2);
                }
                else if (yval >= Ycenter + 10)
                {
                    M1status = ON;
                    M2status = ON;
                    sendMotorCommand(4);
                }
                else
                {
                    M1status = ON;
                    M2status = ON;
                    sendMotorCommand(9);
                }
            }
            if (xval > 0 && yval > 0)
            {

                new_distance = (10 * (Convert.ToInt32(xval / 10))) ^ 2 + (10 * (Convert.ToInt32((yval / 10)))) ^ 2;
                current_speed = new_distance - old_distance;
                //speed.Enqueue((new_distance - old_distance));
                txtSpeed.Text = current_speed.ToString();
                listBoxTest.Items.Add(current_speed.ToString());
                //listBoxTest.SelectedIndex = listBoxTest.Items.Count - 1;
                old_distance = new_distance;
                if (current_speed < SPEED_THRESHOLD)
                {
                    speed.Enqueue(current_speed);
                    if (speed.Count > FRAME_AVERAGE)
                    {
                        if (speed.Average() < SPEED_THRESHOLD)
                        {
                            txtTest.Text = "Target Locked";
                           
                        }
                        else
                        {
                            txtTest.Text = " ";
                        }
                        while(speed.Count> FRAME_AVERAGE)
                        {
                            speed.TryDequeue(out data);
                        }
                       
                    }
                    else
                    {
                        txtTest.Text = " ";
                    }
                }
                else
                {
                    txtTest.Text = " ";
                    while (speed.Count > 0)
                    {
                        speed.TryDequeue(out data);
                    }
                }

            }

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
            if(serialPort1.IsOpen)
            {
                M1status = ON;
                M2status = ON;
                sendMotorCommand(M1STOPPED);
                //sendMotorCommand(1);              
                //sendMotorCommand(M2STOPPED);
                
                horizontalPositionBar.Enabled = true;
                verticalPositionBar.Enabled = true;
                homebtn.Enabled = true;
                fireLeftbtn.Enabled = true;
                fireRightbtn.Enabled = true;
            }

        }

        private void MotorOFFbtn_Click(object sender, EventArgs e)
        {
            //OFF command to motors
            sendMotorCommand(MOTORSOFF);
            M1status = OFF;
            M2status = OFF;
            horizontalPositionBar.Enabled = false;
            verticalPositionBar.Enabled = false;
            homebtn.Enabled = false;
            fireLeftbtn.Enabled = false;
            fireRightbtn.Enabled = false;
        }

        private void sendMotorCommand(int cmd)
        {
            int commandByte = cmd;
            if (M1status == ON && M2status == ON)
            {
                byte[] TxBytes = new Byte[1];
                TxBytes[0] = Convert.ToByte(commandByte);
                //TxBytes[1] = Convert.ToByte(commandByte);
                //TxBytes[2] = Convert.ToByte(dataByteHigh);
                //TxBytes[3] = Convert.ToByte(dataByteLow);
                //TxBytes[4] = Convert.ToByte(endByte);

                //Sends command packet to serial port
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(TxBytes, 0, 1);
                    //Thread.Sleep(10);
                    //serialPort1.Write(TxBytes, 1, 1);
                    //Thread.Sleep(10);
                    //serialPort1.Write(TxBytes, 2, 1);
                    //Thread.Sleep(10);
                    //serialPort1.Write(TxBytes, 3, 1);
                    //Thread.Sleep(10);
                    //serialPort1.Write(TxBytes, 4, 1);
                    //Thread.Sleep(10);
                }
            }
        }

        private void FireLeftbtn_Click(object sender, EventArgs e)
        {
            //Fire left solenoid
            sendMotorCommand(FIRELEFTSOLENOID);
        }

        private void FireRightbtn_Click(object sender, EventArgs e)
        {
            //Fire right solenoid
            sendMotorCommand(FIRERIGHTSOLENOID);
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            //Send home command
            if(M1status ==ON && M2status == ON)
            {
                sendMotorCommand(HOME);
                Thread.Sleep(100);
                verticalPositionBar.Value = 0;
                horizontalPositionBar.Value = 50;
            }

        }

        private void VerticalPositionBar_ValueChanged(object sender, EventArgs e)
        {
            if(M2status == ON)
            {
                if(verticalPositionBar.Value > verticalValue) //Add an && for being at max?
                {
                    sendMotorCommand(M2UP);
                }
                else if (verticalPositionBar.Value <= verticalValue && endstop2Tripped != true)
                {
                    sendMotorCommand(M2DOWN);
                }
            }
        }

        private void HorizontalPositionBar_ValueChanged(object sender, EventArgs e)
        {
            if (M1status == ON)
            {
                if (horizontalPositionBar.Value > horizontalValue) //Add an && for being at max?
                {
                    sendMotorCommand(M1RIGHT);
                }
                else if (horizontalPositionBar.Value <= horizontalValue && endstop1Tripped != true)
                {
                    sendMotorCommand(M1LEFT);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            M1status = ON;
            M2status = ON;
            sendMotorCommand(M1LEFT);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            M1status = ON;
            //M2status = ON;
            sendMotorCommand(M1RIGHT);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            M2status = ON;
            sendMotorCommand(M2UP);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            M2status = ON;
            sendMotorCommand(M2DOWN);
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer_flag = true;
            txtFire.Text = "FIRE";
        }
    }
}

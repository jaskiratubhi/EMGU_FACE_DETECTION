﻿namespace EMGU_FACE_DETECTION
{
    partial class Form1
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
            this.btnDetect = new System.Windows.Forms.Button();
            this.camDevice = new System.Windows.Forms.ComboBox();
            this.videoFeed = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.COMPORTbox = new System.Windows.Forms.ComboBox();
            this.btnCOMConnect = new System.Windows.Forms.Button();
            this.verticalPositionBar = new System.Windows.Forms.TrackBar();
            this.horizontalPositionBar = new System.Windows.Forms.TrackBar();
            this.fireRightbtn = new System.Windows.Forms.Button();
            this.fireLeftbtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.verticalEndStopTxt = new System.Windows.Forms.TextBox();
            this.rotationEndStopTxt = new System.Windows.Forms.TextBox();
            this.homebtn = new System.Windows.Forms.Button();
            this.motorOFFbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.motorONbtn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxTest = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtRight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPositionBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPositionBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetect
            // 
            this.btnDetect.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetect.Location = new System.Drawing.Point(1260, 88);
            this.btnDetect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(136, 84);
            this.btnDetect.TabIndex = 0;
            this.btnDetect.Text = "Start Camera";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.BtnDetect_Click);
            // 
            // camDevice
            // 
            this.camDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camDevice.FormattingEnabled = true;
            this.camDevice.Location = new System.Drawing.Point(1260, 51);
            this.camDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.camDevice.Name = "camDevice";
            this.camDevice.Size = new System.Drawing.Size(136, 28);
            this.camDevice.TabIndex = 1;
            // 
            // videoFeed
            // 
            this.videoFeed.Location = new System.Drawing.Point(14, 26);
            this.videoFeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.videoFeed.Name = "videoFeed";
            this.videoFeed.Size = new System.Drawing.Size(1236, 758);
            this.videoFeed.TabIndex = 2;
            this.videoFeed.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1257, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Device:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(1284, 179);
            this.txtX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(112, 26);
            this.txtX.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1256, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1256, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(1284, 210);
            this.txtY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(112, 26);
            this.txtY.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1397, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "COM PORT";
            // 
            // COMPORTbox
            // 
            this.COMPORTbox.FormattingEnabled = true;
            this.COMPORTbox.Location = new System.Drawing.Point(1402, 51);
            this.COMPORTbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.COMPORTbox.Name = "COMPORTbox";
            this.COMPORTbox.Size = new System.Drawing.Size(121, 28);
            this.COMPORTbox.TabIndex = 15;
            // 
            // btnCOMConnect
            // 
            this.btnCOMConnect.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOMConnect.Location = new System.Drawing.Point(1402, 88);
            this.btnCOMConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCOMConnect.Name = "btnCOMConnect";
            this.btnCOMConnect.Size = new System.Drawing.Size(122, 84);
            this.btnCOMConnect.TabIndex = 14;
            this.btnCOMConnect.Text = "Connect COM";
            this.btnCOMConnect.UseVisualStyleBackColor = true;
            this.btnCOMConnect.Click += new System.EventHandler(this.BtnCOMConnect_Click);
            // 
            // verticalPositionBar
            // 
            this.verticalPositionBar.Enabled = false;
            this.verticalPositionBar.Location = new System.Drawing.Point(1505, 178);
            this.verticalPositionBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verticalPositionBar.Name = "verticalPositionBar";
            this.verticalPositionBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.verticalPositionBar.Size = new System.Drawing.Size(69, 359);
            this.verticalPositionBar.TabIndex = 36;
            this.verticalPositionBar.ValueChanged += new System.EventHandler(this.VerticalPositionBar_ValueChanged);
            // 
            // horizontalPositionBar
            // 
            this.horizontalPositionBar.Enabled = false;
            this.horizontalPositionBar.Location = new System.Drawing.Point(1310, 555);
            this.horizontalPositionBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.horizontalPositionBar.Name = "horizontalPositionBar";
            this.horizontalPositionBar.Size = new System.Drawing.Size(434, 69);
            this.horizontalPositionBar.TabIndex = 35;
            this.horizontalPositionBar.ValueChanged += new System.EventHandler(this.HorizontalPositionBar_ValueChanged);
            // 
            // fireRightbtn
            // 
            this.fireRightbtn.Enabled = false;
            this.fireRightbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireRightbtn.Location = new System.Drawing.Point(1599, 292);
            this.fireRightbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fireRightbtn.Name = "fireRightbtn";
            this.fireRightbtn.Size = new System.Drawing.Size(194, 142);
            this.fireRightbtn.TabIndex = 34;
            this.fireRightbtn.Text = "FIRE RIGHT";
            this.fireRightbtn.UseVisualStyleBackColor = true;
            this.fireRightbtn.Click += new System.EventHandler(this.FireRightbtn_Click);
            // 
            // fireLeftbtn
            // 
            this.fireLeftbtn.Enabled = false;
            this.fireLeftbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireLeftbtn.Location = new System.Drawing.Point(1268, 292);
            this.fireLeftbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fireLeftbtn.Name = "fireLeftbtn";
            this.fireLeftbtn.Size = new System.Drawing.Size(194, 142);
            this.fireLeftbtn.TabIndex = 33;
            this.fireLeftbtn.Text = "FIRE LEFT";
            this.fireLeftbtn.UseVisualStyleBackColor = true;
            this.fireLeftbtn.Click += new System.EventHandler(this.FireLeftbtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1570, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 29);
            this.label12.TabIndex = 41;
            this.label12.Text = "End Stops";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1529, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 29);
            this.label10.TabIndex = 40;
            this.label10.Text = "Vertical";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1529, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 29);
            this.label11.TabIndex = 39;
            this.label11.Text = "Rotation";
            // 
            // verticalEndStopTxt
            // 
            this.verticalEndStopTxt.Location = new System.Drawing.Point(1636, 95);
            this.verticalEndStopTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verticalEndStopTxt.Name = "verticalEndStopTxt";
            this.verticalEndStopTxt.Size = new System.Drawing.Size(112, 26);
            this.verticalEndStopTxt.TabIndex = 38;
            // 
            // rotationEndStopTxt
            // 
            this.rotationEndStopTxt.Location = new System.Drawing.Point(1636, 62);
            this.rotationEndStopTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rotationEndStopTxt.Name = "rotationEndStopTxt";
            this.rotationEndStopTxt.Size = new System.Drawing.Size(112, 26);
            this.rotationEndStopTxt.TabIndex = 37;
            // 
            // homebtn
            // 
            this.homebtn.Enabled = false;
            this.homebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Location = new System.Drawing.Point(1402, 742);
            this.homebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(148, 76);
            this.homebtn.TabIndex = 45;
            this.homebtn.Text = "HOME Rotation";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // motorOFFbtn
            // 
            this.motorOFFbtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorOFFbtn.Location = new System.Drawing.Point(1268, 706);
            this.motorOFFbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.motorOFFbtn.Name = "motorOFFbtn";
            this.motorOFFbtn.Size = new System.Drawing.Size(116, 58);
            this.motorOFFbtn.TabIndex = 44;
            this.motorOFFbtn.Text = "OFF";
            this.motorOFFbtn.UseVisualStyleBackColor = true;
            this.motorOFFbtn.Click += new System.EventHandler(this.MotorOFFbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1263, 608);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 29);
            this.label9.TabIndex = 43;
            this.label9.Text = "Motors";
            // 
            // motorONbtn
            // 
            this.motorONbtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorONbtn.Location = new System.Drawing.Point(1268, 642);
            this.motorONbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.motorONbtn.Name = "motorONbtn";
            this.motorONbtn.Size = new System.Drawing.Size(116, 58);
            this.motorONbtn.TabIndex = 42;
            this.motorONbtn.Text = "ON";
            this.motorONbtn.UseVisualStyleBackColor = true;
            this.motorONbtn.Click += new System.EventHandler(this.MotorONbtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1325, 440);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 58);
            this.button1.TabIndex = 46;
            this.button1.Text = "Left";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1627, 440);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 58);
            this.button2.TabIndex = 47;
            this.button2.Text = "Right";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1556, 742);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 76);
            this.button3.TabIndex = 48;
            this.button3.Text = "HOME Z";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1477, 671);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 58);
            this.button4.TabIndex = 50;
            this.button4.Text = "DOWN";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1477, 608);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 58);
            this.button5.TabIndex = 49;
            this.button5.Text = "UP";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(1636, 129);
            this.txtTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(112, 26);
            this.txtTest.TabIndex = 51;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(1631, 164);
            this.txtSpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(117, 26);
            this.txtSpeed.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1536, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "Test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1536, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 29);
            this.label6.TabIndex = 54;
            this.label6.Text = "Output";
            // 
            // listBoxTest
            // 
            this.listBoxTest.FormattingEnabled = true;
            this.listBoxTest.ItemHeight = 20;
            this.listBoxTest.Location = new System.Drawing.Point(1817, 51);
            this.listBoxTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxTest.Name = "listBoxTest";
            this.listBoxTest.Size = new System.Drawing.Size(134, 764);
            this.listBoxTest.TabIndex = 55;
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // txtLeft
            // 
            this.txtLeft.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeft.Location = new System.Drawing.Point(871, 840);
            this.txtLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(112, 59);
            this.txtLeft.TabIndex = 56;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1402, 178);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 84);
            this.button6.TabIndex = 57;
            this.button6.Text = "Stop Camera";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // txtRight
            // 
            this.txtRight.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRight.Location = new System.Drawing.Point(1038, 840);
            this.txtRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(112, 59);
            this.txtRight.TabIndex = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1988, 980);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.listBoxTest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.motorOFFbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.motorONbtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.verticalEndStopTxt);
            this.Controls.Add(this.rotationEndStopTxt);
            this.Controls.Add(this.verticalPositionBar);
            this.Controls.Add(this.horizontalPositionBar);
            this.Controls.Add(this.fireRightbtn);
            this.Controls.Add(this.fireLeftbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.COMPORTbox);
            this.Controls.Add(this.btnCOMConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoFeed);
            this.Controls.Add(this.camDevice);
            this.Controls.Add(this.btnDetect);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPositionBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPositionBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.ComboBox camDevice;
        private System.Windows.Forms.PictureBox videoFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox COMPORTbox;
        private System.Windows.Forms.Button btnCOMConnect;
        private System.Windows.Forms.TrackBar verticalPositionBar;
        private System.Windows.Forms.TrackBar horizontalPositionBar;
        private System.Windows.Forms.Button fireRightbtn;
        private System.Windows.Forms.Button fireLeftbtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox verticalEndStopTxt;
        private System.Windows.Forms.TextBox rotationEndStopTxt;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button motorOFFbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button motorONbtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxTest;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtRight;
    }
}


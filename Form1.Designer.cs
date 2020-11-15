﻿namespace Serial_Port_Communications_Program
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tBoxSend = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tBoxLength = new System.Windows.Forms.Label();
            this.cBoxNewline = new System.Windows.Forms.CheckBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cBoxRestart = new System.Windows.Forms.CheckBox();
            this.tBoxReceive = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cBoxCleardata = new System.Windows.Forms.CheckBox();
            this.bClear2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lRate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lChar = new System.Windows.Forms.Label();
            this.cBoxSave = new System.Windows.Forms.CheckBox();
            this.bClean = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cBoxDatabits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxComport = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxStopbits = new System.Windows.Forms.ComboBox();
            this.cBoxParitybits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBoxSample = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxDelay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bReset = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tBoxSend
            // 
            this.tBoxSend.Location = new System.Drawing.Point(7, 22);
            this.tBoxSend.Multiline = true;
            this.tBoxSend.Name = "tBoxSend";
            this.tBoxSend.Size = new System.Drawing.Size(490, 118);
            this.tBoxSend.TabIndex = 0;
            this.tBoxSend.TextChanged += new System.EventHandler(this.tBoxSend_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tBoxLength);
            this.groupBox3.Controls.Add(this.cBoxNewline);
            this.groupBox3.Controls.Add(this.bClear);
            this.groupBox3.Controls.Add(this.bSend);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 90);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // tBoxLength
            // 
            this.tBoxLength.AutoSize = true;
            this.tBoxLength.Location = new System.Drawing.Point(427, 39);
            this.tBoxLength.Name = "tBoxLength";
            this.tBoxLength.Size = new System.Drawing.Size(16, 17);
            this.tBoxLength.TabIndex = 3;
            this.tBoxLength.Text = "0";
            // 
            // cBoxNewline
            // 
            this.cBoxNewline.AutoSize = true;
            this.cBoxNewline.Location = new System.Drawing.Point(305, 37);
            this.cBoxNewline.Name = "cBoxNewline";
            this.cBoxNewline.Size = new System.Drawing.Size(88, 21);
            this.cBoxNewline.TabIndex = 2;
            this.cBoxNewline.Text = "New Line";
            this.cBoxNewline.UseVisualStyleBackColor = true;
            this.cBoxNewline.CheckedChanged += new System.EventHandler(this.cBoxNewline_CheckedChanged);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(154, 26);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(125, 43);
            this.bClear.TabIndex = 1;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(23, 26);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(125, 43);
            this.bSend.TabIndex = 0;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.tBoxSend);
            this.groupBox2.Location = new System.Drawing.Point(285, 12);
            this.groupBox2.MinimumSize = new System.Drawing.Size(503, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send";
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(6, 21);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(98, 25);
            this.bConnect.TabIndex = 2;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bDisconnect
            // 
            this.bDisconnect.Location = new System.Drawing.Point(6, 52);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(98, 27);
            this.bDisconnect.TabIndex = 3;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lStatus);
            this.groupBox7.Location = new System.Drawing.Point(118, 9);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(142, 91);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Status";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatus.Location = new System.Drawing.Point(6, 38);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(124, 20);
            this.lStatus.TabIndex = 0;
            this.lStatus.Text = "Disconnected";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bReset);
            this.groupBox6.Controls.Add(this.cBoxRestart);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.bDisconnect);
            this.groupBox6.Controls.Add(this.bConnect);
            this.groupBox6.Location = new System.Drawing.Point(13, 233);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(266, 133);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // cBoxRestart
            // 
            this.cBoxRestart.AutoSize = true;
            this.cBoxRestart.Checked = true;
            this.cBoxRestart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxRestart.Location = new System.Drawing.Point(147, 104);
            this.cBoxRestart.Name = "cBoxRestart";
            this.cBoxRestart.Size = new System.Drawing.Size(76, 21);
            this.cBoxRestart.TabIndex = 5;
            this.cBoxRestart.Text = "Restart";
            this.cBoxRestart.UseVisualStyleBackColor = true;
            // 
            // tBoxReceive
            // 
            this.tBoxReceive.Location = new System.Drawing.Point(7, 22);
            this.tBoxReceive.Multiline = true;
            this.tBoxReceive.Name = "tBoxReceive";
            this.tBoxReceive.Size = new System.Drawing.Size(490, 118);
            this.tBoxReceive.TabIndex = 0;
            this.tBoxReceive.TextChanged += new System.EventHandler(this.tBoxReceive_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cBoxCleardata);
            this.groupBox5.Controls.Add(this.bClear2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(3, 157);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(497, 90);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // cBoxCleardata
            // 
            this.cBoxCleardata.AutoSize = true;
            this.cBoxCleardata.Location = new System.Drawing.Point(177, 37);
            this.cBoxCleardata.Name = "cBoxCleardata";
            this.cBoxCleardata.Size = new System.Drawing.Size(184, 21);
            this.cBoxCleardata.TabIndex = 2;
            this.cBoxCleardata.Text = "Clear Data Automatically";
            this.cBoxCleardata.UseVisualStyleBackColor = true;
            // 
            // bClear2
            // 
            this.bClear2.Location = new System.Drawing.Point(23, 25);
            this.bClear2.Name = "bClear2";
            this.bClear2.Size = new System.Drawing.Size(125, 43);
            this.bClear2.TabIndex = 1;
            this.bClear2.Text = "Clear";
            this.bClear2.UseVisualStyleBackColor = true;
            this.bClear2.Click += new System.EventHandler(this.bClear2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.tBoxReceive);
            this.groupBox4.Location = new System.Drawing.Point(285, 267);
            this.groupBox4.MinimumSize = new System.Drawing.Size(503, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 250);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receive";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Time Taken";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Location = new System.Drawing.Point(150, 27);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(38, 17);
            this.lTime.TabIndex = 1;
            this.lTime.Text = "0 ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Data Rate";
            // 
            // lRate
            // 
            this.lRate.AutoSize = true;
            this.lRate.Location = new System.Drawing.Point(150, 54);
            this.lRate.Name = "lRate";
            this.lRate.Size = new System.Drawing.Size(39, 17);
            this.lRate.TabIndex = 3;
            this.lRate.Text = "0 b/s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Characters";
            // 
            // lChar
            // 
            this.lChar.AutoSize = true;
            this.lChar.Location = new System.Drawing.Point(150, 80);
            this.lChar.Name = "lChar";
            this.lChar.Size = new System.Drawing.Size(16, 17);
            this.lChar.TabIndex = 5;
            this.lChar.Text = "0";
            // 
            // cBoxSave
            // 
            this.cBoxSave.AutoSize = true;
            this.cBoxSave.Location = new System.Drawing.Point(20, 110);
            this.cBoxSave.Name = "cBoxSave";
            this.cBoxSave.Size = new System.Drawing.Size(140, 21);
            this.cBoxSave.TabIndex = 6;
            this.cBoxSave.Text = "Save To Text File";
            this.cBoxSave.UseVisualStyleBackColor = true;
            // 
            // bClean
            // 
            this.bClean.Location = new System.Drawing.Point(169, 103);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(75, 33);
            this.bClean.TabIndex = 2;
            this.bClean.Text = "Clean";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.bClean);
            this.groupBox8.Controls.Add(this.cBoxSave);
            this.groupBox8.Controls.Add(this.lChar);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.lRate);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.lTime);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Location = new System.Drawing.Point(13, 372);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(266, 145);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Transmission Details";
            // 
            // cBoxDatabits
            // 
            this.cBoxDatabits.FormattingEnabled = true;
            this.cBoxDatabits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDatabits.Location = new System.Drawing.Point(119, 79);
            this.cBoxDatabits.Name = "cBoxDatabits";
            this.cBoxDatabits.Size = new System.Drawing.Size(121, 24);
            this.cBoxDatabits.TabIndex = 3;
            this.cBoxDatabits.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Bits";
            // 
            // cBoxComport
            // 
            this.cBoxComport.FormattingEnabled = true;
            this.cBoxComport.Location = new System.Drawing.Point(119, 19);
            this.cBoxComport.Name = "cBoxComport";
            this.cBoxComport.Size = new System.Drawing.Size(121, 24);
            this.cBoxComport.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stop Bits";
            // 
            // cBoxStopbits
            // 
            this.cBoxStopbits.FormattingEnabled = true;
            this.cBoxStopbits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopbits.Location = new System.Drawing.Point(119, 109);
            this.cBoxStopbits.Name = "cBoxStopbits";
            this.cBoxStopbits.Size = new System.Drawing.Size(121, 24);
            this.cBoxStopbits.TabIndex = 7;
            this.cBoxStopbits.Text = "One";
            // 
            // cBoxParitybits
            // 
            this.cBoxParitybits.FormattingEnabled = true;
            this.cBoxParitybits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParitybits.Location = new System.Drawing.Point(119, 139);
            this.cBoxParitybits.Name = "cBoxParitybits";
            this.cBoxParitybits.Size = new System.Drawing.Size(121, 24);
            this.cBoxParitybits.TabIndex = 5;
            this.cBoxParitybits.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parity Bits";
            // 
            // cBoxBaudrate
            // 
            this.cBoxBaudrate.FormattingEnabled = true;
            this.cBoxBaudrate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400",
            "57600",
            "115200"});
            this.cBoxBaudrate.Location = new System.Drawing.Point(119, 48);
            this.cBoxBaudrate.Name = "cBoxBaudrate";
            this.cBoxBaudrate.Size = new System.Drawing.Size(121, 24);
            this.cBoxBaudrate.TabIndex = 9;
            this.cBoxBaudrate.Text = "9600";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBoxSample);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tBoxDelay);
            this.groupBox1.Controls.Add(this.cBoxBaudrate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cBoxParitybits);
            this.groupBox1.Controls.Add(this.cBoxStopbits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cBoxComport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxDatabits);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Controls";
            // 
            // tBoxSample
            // 
            this.tBoxSample.Location = new System.Drawing.Point(120, 196);
            this.tBoxSample.Name = "tBoxSample";
            this.tBoxSample.Size = new System.Drawing.Size(120, 22);
            this.tBoxSample.TabIndex = 13;
            this.tBoxSample.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sample (ms)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Delay (ms)";
            // 
            // tBoxDelay
            // 
            this.tBoxDelay.Location = new System.Drawing.Point(119, 168);
            this.tBoxDelay.Name = "tBoxDelay";
            this.tBoxDelay.Size = new System.Drawing.Size(121, 22);
            this.tBoxDelay.TabIndex = 10;
            this.tBoxDelay.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(800, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 533);
            this.panel1.TabIndex = 5;
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(6, 85);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(98, 26);
            this.bReset.TabIndex = 6;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(818, 580);
            this.Name = "Form1";
            this.Text = "Serial Port Communications Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tBoxSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cBoxNewline;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tBoxReceive;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cBoxCleardata;
        private System.Windows.Forms.Button bClear2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lChar;
        private System.Windows.Forms.CheckBox cBoxSave;
        private System.Windows.Forms.Button bClean;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cBoxDatabits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxComport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxStopbits;
        private System.Windows.Forms.ComboBox cBoxParitybits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxBaudrate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxDelay;
        private System.Windows.Forms.Label tBoxLength;
        private System.Windows.Forms.CheckBox cBoxRestart;
        private System.Windows.Forms.TextBox tBoxSample;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bReset;
    }
}


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
            this.tBoxSendL = new System.Windows.Forms.Label();
            this.cBoxNewline = new System.Windows.Forms.CheckBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cBoxDetails = new System.Windows.Forms.CheckBox();
            this.tBoxReceive = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tBoxReceiveL = new System.Windows.Forms.Label();
            this.cBoxDebug = new System.Windows.Forms.CheckBox();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bSendFile = new System.Windows.Forms.Button();
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
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxSize = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lFileName = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bAccept = new System.Windows.Forms.Button();
            this.bReject = new System.Windows.Forms.Button();
            this.bSelectFile = new System.Windows.Forms.Button();
            this.bFileSend = new System.Windows.Forms.Button();
            this.lIndexList = new System.Windows.Forms.Label();
            this.lPercentage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tBoxSend
            // 
            this.tBoxSend.Location = new System.Drawing.Point(7, 22);
            this.tBoxSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxSend.Multiline = true;
            this.tBoxSend.Name = "tBoxSend";
            this.tBoxSend.Size = new System.Drawing.Size(489, 118);
            this.tBoxSend.TabIndex = 0;
            this.tBoxSend.TextChanged += new System.EventHandler(this.tBoxSend_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tBoxSendL);
            this.groupBox3.Controls.Add(this.cBoxNewline);
            this.groupBox3.Controls.Add(this.bClear);
            this.groupBox3.Controls.Add(this.bSend);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 158);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(497, 90);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // tBoxSendL
            // 
            this.tBoxSendL.AutoSize = true;
            this.tBoxSendL.Location = new System.Drawing.Point(427, 39);
            this.tBoxSendL.Name = "tBoxSendL";
            this.tBoxSendL.Size = new System.Drawing.Size(16, 17);
            this.tBoxSendL.TabIndex = 3;
            this.tBoxSendL.Text = "0";
            // 
            // cBoxNewline
            // 
            this.cBoxNewline.AutoSize = true;
            this.cBoxNewline.Location = new System.Drawing.Point(305, 37);
            this.cBoxNewline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxNewline.Name = "cBoxNewline";
            this.cBoxNewline.Size = new System.Drawing.Size(88, 21);
            this.cBoxNewline.TabIndex = 2;
            this.cBoxNewline.Text = "New Line";
            this.cBoxNewline.UseVisualStyleBackColor = true;
            this.cBoxNewline.CheckedChanged += new System.EventHandler(this.cBoxNewline_CheckedChanged);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(155, 26);
            this.bClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.bSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.MinimumSize = new System.Drawing.Size(503, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(503, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send";
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(11, 21);
            this.bConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(99, 50);
            this.bConnect.TabIndex = 2;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bDisconnect
            // 
            this.bDisconnect.Location = new System.Drawing.Point(11, 78);
            this.bDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(99, 50);
            this.bDisconnect.TabIndex = 3;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lStatus);
            this.groupBox7.Location = new System.Drawing.Point(117, 21);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(141, 75);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Status";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatus.Location = new System.Drawing.Point(5, 31);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(124, 20);
            this.lStatus.TabIndex = 0;
            this.lStatus.Text = "Disconnected";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cBoxDetails);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.bDisconnect);
            this.groupBox6.Controls.Add(this.bConnect);
            this.groupBox6.Location = new System.Drawing.Point(13, 231);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(267, 149);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // cBoxDetails
            // 
            this.cBoxDetails.AutoSize = true;
            this.cBoxDetails.Checked = true;
            this.cBoxDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxDetails.Location = new System.Drawing.Point(127, 107);
            this.cBoxDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxDetails.Name = "cBoxDetails";
            this.cBoxDetails.Size = new System.Drawing.Size(121, 21);
            this.cBoxDetails.TabIndex = 5;
            this.cBoxDetails.Text = "Enable Details";
            this.cBoxDetails.UseVisualStyleBackColor = true;
            this.cBoxDetails.CheckedChanged += new System.EventHandler(this.cBoxDetails_CheckedChanged);
            // 
            // tBoxReceive
            // 
            this.tBoxReceive.Location = new System.Drawing.Point(7, 22);
            this.tBoxReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxReceive.Multiline = true;
            this.tBoxReceive.Name = "tBoxReceive";
            this.tBoxReceive.Size = new System.Drawing.Size(489, 118);
            this.tBoxReceive.TabIndex = 0;
            this.tBoxReceive.TextChanged += new System.EventHandler(this.tBoxReceive_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tBoxReceiveL);
            this.groupBox5.Controls.Add(this.cBoxDebug);
            this.groupBox5.Controls.Add(this.cBoxCleardata);
            this.groupBox5.Controls.Add(this.bClear2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(3, 158);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(497, 90);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // tBoxReceiveL
            // 
            this.tBoxReceiveL.AutoSize = true;
            this.tBoxReceiveL.Location = new System.Drawing.Point(460, 38);
            this.tBoxReceiveL.Name = "tBoxReceiveL";
            this.tBoxReceiveL.Size = new System.Drawing.Size(16, 17);
            this.tBoxReceiveL.TabIndex = 4;
            this.tBoxReceiveL.Text = "0";
            // 
            // cBoxDebug
            // 
            this.cBoxDebug.AutoSize = true;
            this.cBoxDebug.Location = new System.Drawing.Point(369, 36);
            this.cBoxDebug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxDebug.Name = "cBoxDebug";
            this.cBoxDebug.Size = new System.Drawing.Size(72, 21);
            this.cBoxDebug.TabIndex = 3;
            this.cBoxDebug.Text = "Debug";
            this.cBoxDebug.UseVisualStyleBackColor = true;
            // 
            // cBoxCleardata
            // 
            this.cBoxCleardata.AutoSize = true;
            this.cBoxCleardata.Location = new System.Drawing.Point(171, 36);
            this.cBoxCleardata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxCleardata.Name = "cBoxCleardata";
            this.cBoxCleardata.Size = new System.Drawing.Size(184, 21);
            this.cBoxCleardata.TabIndex = 2;
            this.cBoxCleardata.Text = "Clear Data Automatically";
            this.cBoxCleardata.UseVisualStyleBackColor = true;
            // 
            // bClear2
            // 
            this.bClear2.Location = new System.Drawing.Point(23, 25);
            this.bClear2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.MinimumSize = new System.Drawing.Size(503, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(503, 250);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receive";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Time Taken";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Location = new System.Drawing.Point(120, 27);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(38, 17);
            this.lTime.TabIndex = 1;
            this.lTime.Text = "0 ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Data Rate";
            // 
            // lRate
            // 
            this.lRate.AutoSize = true;
            this.lRate.Location = new System.Drawing.Point(120, 54);
            this.lRate.Name = "lRate";
            this.lRate.Size = new System.Drawing.Size(39, 17);
            this.lRate.TabIndex = 3;
            this.lRate.Text = "0 b/s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Characters";
            // 
            // lChar
            // 
            this.lChar.AutoSize = true;
            this.lChar.Location = new System.Drawing.Point(120, 80);
            this.lChar.Name = "lChar";
            this.lChar.Size = new System.Drawing.Size(16, 17);
            this.lChar.TabIndex = 5;
            this.lChar.Text = "0";
            // 
            // cBoxSave
            // 
            this.cBoxSave.AutoSize = true;
            this.cBoxSave.Location = new System.Drawing.Point(20, 110);
            this.cBoxSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxSave.Name = "cBoxSave";
            this.cBoxSave.Size = new System.Drawing.Size(140, 21);
            this.cBoxSave.TabIndex = 6;
            this.cBoxSave.Text = "Save To Text File";
            this.cBoxSave.UseVisualStyleBackColor = true;
            // 
            // bClean
            // 
            this.bClean.Location = new System.Drawing.Point(169, 103);
            this.bClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(75, 33);
            this.bClean.TabIndex = 2;
            this.bClean.Text = "Clean";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.panel3);
            this.groupBox8.Controls.Add(this.bSendFile);
            this.groupBox8.Controls.Add(this.bClean);
            this.groupBox8.Controls.Add(this.cBoxSave);
            this.groupBox8.Controls.Add(this.lChar);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.lRate);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.lTime);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Location = new System.Drawing.Point(13, 382);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(267, 145);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Transmission Details";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox10);
            this.panel3.Location = new System.Drawing.Point(13, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 74);
            this.panel3.TabIndex = 2;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Location = new System.Drawing.Point(5, 5);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Size = new System.Drawing.Size(143, 66);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Not Enabled";
            // 
            // bSendFile
            // 
            this.bSendFile.Location = new System.Drawing.Point(169, 27);
            this.bSendFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSendFile.Name = "bSendFile";
            this.bSendFile.Size = new System.Drawing.Size(75, 60);
            this.bSendFile.TabIndex = 7;
            this.bSendFile.Text = "Send File";
            this.bSendFile.UseVisualStyleBackColor = true;
            this.bSendFile.Click += new System.EventHandler(this.bSendFile_Click);
            // 
            // cBoxDatabits
            // 
            this.cBoxDatabits.FormattingEnabled = true;
            this.cBoxDatabits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDatabits.Location = new System.Drawing.Point(119, 86);
            this.cBoxDatabits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxDatabits.Name = "cBoxDatabits";
            this.cBoxDatabits.Size = new System.Drawing.Size(121, 24);
            this.cBoxDatabits.TabIndex = 3;
            this.cBoxDatabits.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Bits";
            // 
            // cBoxComport
            // 
            this.cBoxComport.FormattingEnabled = true;
            this.cBoxComport.Location = new System.Drawing.Point(119, 26);
            this.cBoxComport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxComport.Name = "cBoxComport";
            this.cBoxComport.Size = new System.Drawing.Size(121, 24);
            this.cBoxComport.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 121);
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
            this.cBoxStopbits.Location = new System.Drawing.Point(119, 116);
            this.cBoxStopbits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.cBoxParitybits.Location = new System.Drawing.Point(119, 146);
            this.cBoxParitybits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxParitybits.Name = "cBoxParitybits";
            this.cBoxParitybits.Size = new System.Drawing.Size(121, 24);
            this.cBoxParitybits.TabIndex = 5;
            this.cBoxParitybits.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 150);
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
            this.cBoxBaudrate.Location = new System.Drawing.Point(119, 55);
            this.cBoxBaudrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxBaudrate.Name = "cBoxBaudrate";
            this.cBoxBaudrate.Size = new System.Drawing.Size(121, 24);
            this.cBoxBaudrate.TabIndex = 9;
            this.cBoxBaudrate.Text = "9600";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tBoxSize);
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(267, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Controls";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Packet Size";
            // 
            // tBoxSize
            // 
            this.tBoxSize.Location = new System.Drawing.Point(119, 175);
            this.tBoxSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxSize.Name = "tBoxSize";
            this.tBoxSize.Size = new System.Drawing.Size(121, 22);
            this.tBoxSize.TabIndex = 10;
            this.tBoxSize.Text = "60";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MinimumSize = new System.Drawing.Size(800, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 542);
            this.panel1.TabIndex = 5;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lPercentage);
            this.groupBox9.Controls.Add(this.lIndexList);
            this.groupBox9.Controls.Add(this.bFileSend);
            this.groupBox9.Controls.Add(this.bSelectFile);
            this.groupBox9.Controls.Add(this.bReject);
            this.groupBox9.Controls.Add(this.bAccept);
            this.groupBox9.Controls.Add(this.progressBar1);
            this.groupBox9.Controls.Add(this.lFileName);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Location = new System.Drawing.Point(7, 4);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Size = new System.Drawing.Size(253, 199);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "File Transfer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name:";
            // 
            // lFileName
            // 
            this.lFileName.AutoSize = true;
            this.lFileName.Location = new System.Drawing.Point(52, 31);
            this.lFileName.Name = "lFileName";
            this.lFileName.Size = new System.Drawing.Size(73, 17);
            this.lFileName.TabIndex = 1;
            this.lFileName.Text = "Select File";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 110);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(221, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(29, 146);
            this.bAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(89, 42);
            this.bAccept.TabIndex = 6;
            this.bAccept.Text = "Accept";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // bReject
            // 
            this.bReject.Location = new System.Drawing.Point(132, 146);
            this.bReject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bReject.Name = "bReject";
            this.bReject.Size = new System.Drawing.Size(88, 42);
            this.bReject.TabIndex = 7;
            this.bReject.Text = "Reject";
            this.bReject.UseVisualStyleBackColor = true;
            this.bReject.Click += new System.EventHandler(this.bReject_Click);
            // 
            // bSelectFile
            // 
            this.bSelectFile.Location = new System.Drawing.Point(29, 58);
            this.bSelectFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSelectFile.Name = "bSelectFile";
            this.bSelectFile.Size = new System.Drawing.Size(88, 41);
            this.bSelectFile.TabIndex = 8;
            this.bSelectFile.Text = "Select File";
            this.bSelectFile.UseVisualStyleBackColor = true;
            this.bSelectFile.Click += new System.EventHandler(this.bSelectFile_Click);
            // 
            // bFileSend
            // 
            this.bFileSend.Location = new System.Drawing.Point(132, 59);
            this.bFileSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bFileSend.Name = "bFileSend";
            this.bFileSend.Size = new System.Drawing.Size(88, 41);
            this.bFileSend.TabIndex = 9;
            this.bFileSend.Text = "Send";
            this.bFileSend.UseVisualStyleBackColor = true;
            this.bFileSend.Click += new System.EventHandler(this.bFileSend_Click);
            // 
            // lIndexList
            // 
            this.lIndexList.AutoSize = true;
            this.lIndexList.Location = new System.Drawing.Point(173, 31);
            this.lIndexList.Name = "lIndexList";
            this.lIndexList.Size = new System.Drawing.Size(28, 17);
            this.lIndexList.TabIndex = 10;
            this.lIndexList.Text = "0/0";
            // 
            // lPercentage
            // 
            this.lPercentage.AutoSize = true;
            this.lPercentage.Location = new System.Drawing.Point(109, 112);
            this.lPercentage.Name = "lPercentage";
            this.lPercentage.Size = new System.Drawing.Size(32, 17);
            this.lPercentage.TabIndex = 11;
            this.lPercentage.Text = "0 %";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox9);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 210);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 542);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(818, 579);
            this.Name = "Form1";
            this.Text = " Serial Port Communication Program";
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
            this.panel3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tBoxSize;
        private System.Windows.Forms.Label tBoxSendL;
        private System.Windows.Forms.CheckBox cBoxDetails;
        private System.Windows.Forms.CheckBox cBoxDebug;
        private System.Windows.Forms.Button bSendFile;
        private System.Windows.Forms.Label tBoxReceiveL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lPercentage;
        private System.Windows.Forms.Label lIndexList;
        private System.Windows.Forms.Button bFileSend;
        private System.Windows.Forms.Button bSelectFile;
        private System.Windows.Forms.Button bReject;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lFileName;
        private System.Windows.Forms.Label label8;
    }
}


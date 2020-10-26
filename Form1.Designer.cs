namespace Serial_Port_Communications_Program
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxParitybits = new System.Windows.Forms.ComboBox();
            this.cBoxStopbits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxComport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxDatabits = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBoxNewline = new System.Windows.Forms.CheckBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.tBoxSend = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cBoxCleardata = new System.Windows.Forms.CheckBox();
            this.bClear2 = new System.Windows.Forms.Button();
            this.tBoxReceive = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.bConnect = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cBoxSave = new System.Windows.Forms.CheckBox();
            this.lChar = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lRate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bClean = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(267, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Controls";
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
            this.cBoxBaudrate.Name = "cBoxBaudrate";
            this.cBoxBaudrate.Size = new System.Drawing.Size(121, 24);
            this.cBoxBaudrate.TabIndex = 9;
            this.cBoxBaudrate.Text = "9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parity Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Baud Rate";
            // 
            // cBoxParitybits
            // 
            this.cBoxParitybits.FormattingEnabled = true;
            this.cBoxParitybits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParitybits.Location = new System.Drawing.Point(119, 146);
            this.cBoxParitybits.Name = "cBoxParitybits";
            this.cBoxParitybits.Size = new System.Drawing.Size(121, 24);
            this.cBoxParitybits.TabIndex = 5;
            this.cBoxParitybits.Text = "None";
            // 
            // cBoxStopbits
            // 
            this.cBoxStopbits.FormattingEnabled = true;
            this.cBoxStopbits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopbits.Location = new System.Drawing.Point(119, 116);
            this.cBoxStopbits.Name = "cBoxStopbits";
            this.cBoxStopbits.Size = new System.Drawing.Size(121, 24);
            this.cBoxStopbits.TabIndex = 7;
            this.cBoxStopbits.Text = "One";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stop Bits";
            // 
            // cBoxComport
            // 
            this.cBoxComport.FormattingEnabled = true;
            this.cBoxComport.Location = new System.Drawing.Point(119, 25);
            this.cBoxComport.Name = "cBoxComport";
            this.cBoxComport.Size = new System.Drawing.Size(121, 24);
            this.cBoxComport.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Bits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port";
            // 
            // cBoxDatabits
            // 
            this.cBoxDatabits.FormattingEnabled = true;
            this.cBoxDatabits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDatabits.Location = new System.Drawing.Point(119, 86);
            this.cBoxDatabits.Name = "cBoxDatabits";
            this.cBoxDatabits.Size = new System.Drawing.Size(121, 24);
            this.cBoxDatabits.TabIndex = 3;
            this.cBoxDatabits.Text = "8";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.tBoxSend);
            this.groupBox2.Location = new System.Drawing.Point(285, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBoxNewline);
            this.groupBox3.Controls.Add(this.bClear);
            this.groupBox3.Controls.Add(this.bSend);
            this.groupBox3.Location = new System.Drawing.Point(7, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 90);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // cBoxNewline
            // 
            this.cBoxNewline.AutoSize = true;
            this.cBoxNewline.Location = new System.Drawing.Point(305, 34);
            this.cBoxNewline.Name = "cBoxNewline";
            this.cBoxNewline.Size = new System.Drawing.Size(88, 21);
            this.cBoxNewline.TabIndex = 2;
            this.cBoxNewline.Text = "New Line";
            this.cBoxNewline.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(154, 23);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(125, 43);
            this.bClear.TabIndex = 1;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(23, 23);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(125, 43);
            this.bSend.TabIndex = 0;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tBoxSend
            // 
            this.tBoxSend.Location = new System.Drawing.Point(7, 22);
            this.tBoxSend.Multiline = true;
            this.tBoxSend.Name = "tBoxSend";
            this.tBoxSend.Size = new System.Drawing.Size(490, 118);
            this.tBoxSend.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.tBoxReceive);
            this.groupBox4.Location = new System.Drawing.Point(285, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 250);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receive";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cBoxCleardata);
            this.groupBox5.Controls.Add(this.bClear2);
            this.groupBox5.Location = new System.Drawing.Point(7, 146);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(373, 90);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // cBoxCleardata
            // 
            this.cBoxCleardata.AutoSize = true;
            this.cBoxCleardata.Location = new System.Drawing.Point(177, 34);
            this.cBoxCleardata.Name = "cBoxCleardata";
            this.cBoxCleardata.Size = new System.Drawing.Size(184, 21);
            this.cBoxCleardata.TabIndex = 2;
            this.cBoxCleardata.Text = "Clear Data Automatically";
            this.cBoxCleardata.UseVisualStyleBackColor = true;
            // 
            // bClear2
            // 
            this.bClear2.Location = new System.Drawing.Point(23, 22);
            this.bClear2.Name = "bClear2";
            this.bClear2.Size = new System.Drawing.Size(125, 43);
            this.bClear2.TabIndex = 1;
            this.bClear2.Text = "Clear";
            this.bClear2.UseVisualStyleBackColor = true;
            this.bClear2.Click += new System.EventHandler(this.bClear2_Click);
            // 
            // tBoxReceive
            // 
            this.tBoxReceive.Location = new System.Drawing.Point(7, 22);
            this.tBoxReceive.Multiline = true;
            this.tBoxReceive.Name = "tBoxReceive";
            this.tBoxReceive.Size = new System.Drawing.Size(490, 118);
            this.tBoxReceive.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.bDisconnect);
            this.groupBox6.Controls.Add(this.bConnect);
            this.groupBox6.Location = new System.Drawing.Point(13, 208);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(266, 133);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lStatus);
            this.groupBox7.Location = new System.Drawing.Point(118, 22);
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
            // bDisconnect
            // 
            this.bDisconnect.Location = new System.Drawing.Point(6, 70);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(98, 43);
            this.bDisconnect.TabIndex = 3;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(6, 21);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(98, 43);
            this.bConnect.TabIndex = 2;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
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
            this.groupBox8.Location = new System.Drawing.Point(13, 348);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(260, 170);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Transmission Details";
            // 
            // cBoxSave
            // 
            this.cBoxSave.AutoSize = true;
            this.cBoxSave.Location = new System.Drawing.Point(15, 122);
            this.cBoxSave.Name = "cBoxSave";
            this.cBoxSave.Size = new System.Drawing.Size(140, 21);
            this.cBoxSave.TabIndex = 6;
            this.cBoxSave.Text = "Save To Text File";
            this.cBoxSave.UseVisualStyleBackColor = true;
            // 
            // lChar
            // 
            this.lChar.AutoSize = true;
            this.lChar.Location = new System.Drawing.Point(150, 89);
            this.lChar.Name = "lChar";
            this.lChar.Size = new System.Drawing.Size(16, 17);
            this.lChar.TabIndex = 5;
            this.lChar.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Characters";
            // 
            // lRate
            // 
            this.lRate.AutoSize = true;
            this.lRate.Location = new System.Drawing.Point(150, 61);
            this.lRate.Name = "lRate";
            this.lRate.Size = new System.Drawing.Size(39, 17);
            this.lRate.TabIndex = 3;
            this.lRate.Text = "0 b/s";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Data Rate";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Location = new System.Drawing.Point(150, 34);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(38, 17);
            this.lTime.TabIndex = 1;
            this.lTime.Text = "0 ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Time Taken";
            // 
            // bClean
            // 
            this.bClean.Location = new System.Drawing.Point(164, 115);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(75, 33);
            this.bClean.TabIndex = 2;
            this.bClean.Text = "Clean";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Serial Port Communications Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxBaudrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxParitybits;
        private System.Windows.Forms.ComboBox cBoxStopbits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxComport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxDatabits;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cBoxNewline;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.TextBox tBoxSend;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cBoxCleardata;
        private System.Windows.Forms.Button bClear2;
        private System.Windows.Forms.TextBox tBoxReceive;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox cBoxSave;
        private System.Windows.Forms.Label lChar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bClean;
    }
}


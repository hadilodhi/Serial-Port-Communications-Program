using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Serial_Port_Communications_Program
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();

        string Dir = Directory.GetCurrentDirectory() + @"\Output.txt";

        string SendData;
        string ReceiveData;
        string SendBack;
        decimal elapsedms;
        decimal elapseds;
        decimal ReceiveDatal;
        decimal Rate;
        string RateS;
        int PacketSize;
        List<string> SendDataLarge = new List<string>();
        int index = 0;
        decimal list = 0;
        decimal percent;
        int flag = -1;
        int flag1 = 1;
        string OpenFile;
        byte[] fileBytes;
        string data;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Width = 383;
            groupBox2.Height = 210;
            groupBox4.Width = 383;
            groupBox4.Height = 210;
            tBoxSend.Width = 370;
            tBoxSend.Height = 108;
            tBoxReceive.Width = 370;
            tBoxReceive.Height = 108;
            groupBox4.Top = 225;

            panel2.Hide();
            panel3.Hide();

            cBoxComport.Items.AddRange(SerialPort.GetPortNames());
            serialPort1.NewLine = Convert.ToChar(1).ToString();
            bDisconnect.Enabled = false;
            bSendFile.Enabled = false;
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComport.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudrate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDatabits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopbits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParitybits.Text);
                PacketSize = Convert.ToInt32(tBoxSize.Text);

                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                serialPort1.Write(cBoxBaudrate.Text);
                serialPort1.Close();
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudrate.Text);

                serialPort1.Open();
                lStatus.Text = "Connected";
                bConnect.Enabled = false;
                bDisconnect.Enabled = true;
                cBoxComport.Enabled = false;
                cBoxBaudrate.Enabled = false;
                cBoxDatabits.Enabled = false;
                cBoxStopbits.Enabled = false;
                cBoxParitybits.Enabled = false;
                tBoxSize.Enabled = false;
                bSendFile.Enabled = true;
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                serialPort1.Write(Convert.ToChar(126).ToString());

                serialPort1.Close();
                lStatus.Text = "Disconnected";
                bConnect.Enabled = true;
                bDisconnect.Enabled = false;
                cBoxComport.Enabled = true;
                cBoxBaudrate.Enabled = true;
                cBoxDatabits.Enabled = true;
                cBoxStopbits.Enabled = true;
                cBoxParitybits.Enabled = true;
                tBoxSize.Enabled = true;
            }
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            index = 0;
            list = 0;
            SendDataLarge.Clear();
            if (serialPort1.IsOpen)
            {
                SendData = tBoxSend.Text;
                BreakupData();
                if (cBoxSave.Checked)
                {
                    try
                    {
                        using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter(Dir, true))
                        {
                            file.WriteLine("Sent:\n\n" + SendData + "\n\n");
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BreakupData()
        {
            for (int i = 0; i < SendData.Length; i += PacketSize)
            {
                if ((i + PacketSize) < SendData.Length)
                {
                    SendDataLarge.Add(SendData.Substring(i, PacketSize));
                    list++;
                }
                else
                {
                    SendDataLarge.Add(SendData.Substring(i));
                    list++;
                }
            }
            SendData = SendDataLarge[index];
            index++;
            if (progressBar1.Value >= 1)
            {
                CalcProgress();
                SendBack = index + "/" + list + Convert.ToChar(11).ToString();
                serialPort1.Write(SendBack);
            }
            else
            {
                SendDataChunk();
            }
        }

        private void CalcProgress()
        {
            if (index >= 1 && index <= list)
            {
                lIndexList.Text = index + "/" + list;
                percent = index / list;
                percent *= 100;
                if (percent < 1 || percent > 100)
                {
                    percent = 1;
                }
                progressBar1.Value = decimal.ToInt32(percent);
                lPercentage.Text = percent.ToString("#") + " %";
            }
        }

        private void SendDataChunk()
        {
            if (cBoxNewline.Checked)
            {
                serialPort1.Write(Convert.ToChar(2).ToString());
                Thread.Sleep(1);
                serialPort1.WriteLine(SendData);
                if(progressBar1.Value >= 1)
                {
                    Thread.Sleep(1);
                    serialPort1.Write(Convert.ToChar(8).ToString());
                }
                if (cBoxDetails.Checked)
                {
                    Thread.Sleep(1);
                    serialPort1.Write(Convert.ToChar(10).ToString());
                }
                Thread.Sleep(1);
                serialPort1.Write(Convert.ToChar(3).ToString());
            }

            else
            {
                serialPort1.Write(Convert.ToChar(2).ToString());
                Thread.Sleep(1);
                serialPort1.Write(SendData);
                if (progressBar1.Value >= 1)
                {
                    Thread.Sleep(1);
                    serialPort1.Write(Convert.ToChar(8).ToString());
                }
                if (cBoxDetails.Checked)
                {
                    Thread.Sleep(1);
                    serialPort1.Write(Convert.ToChar(10).ToString());
                }
                Thread.Sleep(1);
                serialPort1.Write(Convert.ToChar(3).ToString());
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            ReceiveData += serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));

        }

        private void ShowData(object sender, EventArgs e)
        {
            if (ReceiveData.Contains(Convert.ToChar(2).ToString()))
            {
                stopwatch.Start();
                ReceiveData = "";
            }
            else if (ReceiveData.Contains(Convert.ToChar(3).ToString()))
            {
                stopwatch.Stop();
                ReceiveData = ReceiveData.Replace(Convert.ToChar(3).ToString(), "");
                if (ReceiveData.Contains(Convert.ToChar(10).ToString()))
                {
                    ReceiveData = ReceiveData.Replace(Convert.ToChar(10).ToString(), "");
                    flag1 = 1;
                }
                else
                {
                    flag1 = 0;
                }
                if (ReceiveData.Contains(Convert.ToChar(8).ToString()))
                {
                    if (progressBar1.Value >= 1)
                    {
                        index++;
                        CalcProgress();
                    }
                    ReceiveData = ReceiveData.Replace(Convert.ToChar(8).ToString(), "");
                    data += ReceiveData;
                    ReceiveDatal = ReceiveData.Length;
                }
                else
                {
                    Processing();
                }
                elapsedms = stopwatch.ElapsedMilliseconds;
                if (elapsedms <= 0 || elapsedms >=10000)
                {
                    elapsedms = 1;
                }
                elapsedms -= 1 * 2;
                if (elapsedms <= 1000)
                {
                    lTime.Text = elapsedms.ToString() + " ms";
                }
                else
                {
                    elapsedms /= 1000;
                    lTime.Text = elapsedms.ToString("#") + " s";
                    elapsedms *= 1000;
                }
                lChar.Text = (ReceiveDatal).ToString();
                if (flag1 == 1)
                {
                    SendBack = elapsedms + "/" + ReceiveDatal + Convert.ToChar(4).ToString();
                }
                else
                {
                    SendBack = Convert.ToChar(4).ToString();
                }
                CalcRate();
                serialPort1.Write(SendBack);
                stopwatch.Reset();
                ReceiveData = "";
            }
            else if (ReceiveData.Contains(Convert.ToChar(4).ToString()))
            {
                ReceiveData = ReceiveData.Replace(Convert.ToChar(4).ToString(), "");
                try
                {
                    ReceiveDatal = Convert.ToDecimal(ReceiveData.Substring(ReceiveData.IndexOf("/") + 1));
                    elapsedms = Convert.ToDecimal(ReceiveData.Substring(0, ReceiveData.IndexOf("/")));
                    if (elapsedms <= 1000)
                    {
                        lTime.Text = elapsedms.ToString() + " ms";
                    }
                    else
                    {
                        elapsedms /= 1000;
                        lTime.Text = elapsedms.ToString("#") + " s";
                        elapsedms *= 1000;
                    }
                    lChar.Text = (ReceiveDatal).ToString();
                    CalcRate();
                }
                catch
                {

                }
                ReceiveData = "";
                if (index != list)
                {
                    SendData = SendDataLarge[index];
                    SendDataChunk();
                    index++;
                    if (flag == 1)
                        if(progressBar1.Value >=1)
                        CalcProgress();
                }
                else
                {
                    if(progressBar1.Value >= 1)
                    {
                        serialPort1.Write(Convert.ToChar(12).ToString());
                    }
                    index = 0;
                    list = 0;
                    SendDataLarge.Clear();
                }
            }
            else if (ReceiveData.Contains(Convert.ToChar(5).ToString()))
            {
                panel2.Show();
                bSendFile.Enabled = false;
                progressBar1.Value = 1;
                lPercentage.Text = "1 %";
                ReceiveData = ReceiveData.Replace(Convert.ToChar(5).ToString(), "");
                lFileName.Text = ReceiveData;
                bAccept.Enabled = true;
                bReject.Enabled = true;
                bFileSend.Enabled = false;
                bSelectFile.Enabled = false;
                ReceiveData = "";
            }
            else if (ReceiveData.Contains(Convert.ToChar(6).ToString()))
            {
                progressBar1.Value = 2;
                lPercentage.Text = "2 %";
                try
                {
                    FileStream stream = File.OpenRead(OpenFile);
                    fileBytes = new byte[stream.Length];
                    stream.Read(fileBytes, 0, fileBytes.Length);
                    stream.Close();
                    SendData = Convert.ToBase64String(fileBytes);
                    BreakupData();
                }
                catch
                {

                }
                ReceiveData = "";
            }
            else if (ReceiveData.Contains(Convert.ToChar(7).ToString()))
            {
                progressBar1.Value = 0;
                lPercentage.Text = "0 %";
                bFileSend.Enabled = true;
                MessageBox.Show("Outgoing Connection Rejected");
                ReceiveData = "";
                bSendFile.Enabled = true;
            }
            else if (ReceiveData.Contains(Convert.ToChar(12).ToString()))
            {
                ReceiveData = ReceiveData.Replace(Convert.ToChar(12).ToString(), "");
                try
                {
                    fileBytes = Convert.FromBase64String(data);
                    using (Stream file = File.OpenWrite(Directory.GetCurrentDirectory() + "/" + lFileName.Text))
                    {
                        file.Write(fileBytes, 0, fileBytes.Length);
                    }
                    progressBar1.Value = 100;
                    lPercentage.Text = "100 %";
                    MessageBox.Show("File Received");
                    progressBar1.Value = 0;
                    lPercentage.Text = "0 %";
                    index = 0;
                    list = 0;
                    lIndexList.Text = "0/0";
                    panel2.Hide();
                    serialPort1.Write(Convert.ToChar(9).ToString());
                    data = "";
                    bSendFile.Enabled = true;
                    ReceiveData = "";
                }
                catch
                {
                    SendBack = Convert.ToChar(7).ToString();
                    serialPort1.Write(SendBack);
                    bSendFile.Enabled = true;
                    progressBar1.Value = 0;
                    lPercentage.Text = "0 %";
                    index = 0;
                    list = 0;
                    lIndexList.Text = "0/0";
                    panel2.Hide();
                    data = "";
                    ReceiveData = "";
                }
               
            }
            else if (ReceiveData.Contains(Convert.ToChar(9).ToString()))
            {
                progressBar1.Value = 100;
                lPercentage.Text = "100 %";
                MessageBox.Show("File Sent");
                progressBar1.Value = 0;
                lPercentage.Text = "0 %";
                index = 0;
                list = 0;
                lIndexList.Text = "0/0";
                bSendFile.Enabled = true;
                bFileSend.Enabled = true;
                ReceiveData = "";
            }
            else if (ReceiveData.Contains(Convert.ToChar(11).ToString()))
            {
                ReceiveData = ReceiveData.Replace(Convert.ToChar(11).ToString(), "");
                try
                {
                    list = Int32.Parse(ReceiveData.Substring(ReceiveData.IndexOf("/") + 1));
                    index = Int32.Parse(ReceiveData.Substring(0, ReceiveData.IndexOf("/")));
                    if (flag == 1)
                        CalcProgress();
                }
                catch
                {
                    SendBack = lFileName.Text + Convert.ToChar(7).ToString();
                    serialPort1.Write(SendBack);
                }
                SendBack = Convert.ToChar(17).ToString();
                serialPort1.Write(SendBack);
                ReceiveData = "";
            }
            else if (ReceiveData.Contains(Convert.ToChar(17).ToString()))
            {
                ReceiveData = "";
                SendDataChunk();
            }
            else if (cBoxDebug.Checked)
            {
                Processing();
            }

            void Processing()
            {
                if (ReceiveData.Contains(Convert.ToChar(1).ToString()))
                {
                    if (cBoxCleardata.Checked || tBoxReceive.Text == "")
                    {
                        ReceiveData = ReceiveData.Replace(Convert.ToChar(1).ToString(), "");
                        ReceiveDatal = ReceiveData.Length + 2;
                        Output();
                    }
                    else
                    {
                        ReceiveData = ReceiveData.Replace(Convert.ToChar(1).ToString(), "");
                        ReceiveData = string.Concat("" + System.Environment.NewLine, ReceiveData);
                        ReceiveDatal = ReceiveData.Length;
                        Output();
                    }
                }
                else
                {
                    ReceiveDatal = ReceiveData.Length;
                    Output();
                }
            }

            void Output()
            {
                if (cBoxCleardata.Checked)
                {
                    tBoxReceive.Text = ReceiveData;
                }
                else
                {
                    tBoxReceive.Text += ReceiveData;
                }
                if (cBoxSave.Checked)
                {
                    try
                    {
                        using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter(Dir, true))
                        {
                            file.WriteLine("Received:\n\n" + ReceiveData + "\n\n");
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            void CalcRate()
            {
                if (elapsedms == 0)
                {
                    elapsedms = 1;
                }
                elapseds = elapsedms / 1000;
                ReceiveDatal *= 8;
                Rate = ReceiveDatal / elapseds;
                if (Rate <= 1000)
                {
                    RateS = Rate.ToString("#");
                    lRate.Text = RateS + " b/s";
                }
                else if (Rate <= 1000000)
                {
                    Rate = Rate / 1000;
                    RateS = Rate.ToString("#");
                    lRate.Text = RateS + " Kb/s";
                }
                else if (Rate <= 1000000000)
                {
                    Rate = Rate / 1000000;
                    RateS = Rate.ToString("#");
                    lRate.Text = RateS + " Mb/s";
                }
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (tBoxSend.Text != "")
            {
                tBoxSend.Text = "";
            }
        }

        private void bClear2_Click(object sender, EventArgs e)
        {
            if (tBoxReceive.Text != "")
            {
                tBoxReceive.Text = "";
            }
        }

        private void bClean_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(Dir, "");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            groupBox2.Width = panel1.Width - 220;
            groupBox2.Height = ((panel1.Height - 533) / 2) + 255;
            groupBox4.Width = panel1.Width - 220;
            groupBox4.Height = ((panel1.Height - 533) / 2) + 255;
            tBoxSend.Width = groupBox2.Width - 13;
            tBoxSend.Height = groupBox2.Height - 102;
            tBoxReceive.Width = groupBox4.Width - 13;
            tBoxReceive.Height = groupBox4.Height- 102;
            groupBox4.Top = groupBox4.Height + 20;

        }

        private void tBoxSend_TextChanged(object sender, EventArgs e)
        {
            tBoxSend.ScrollBars = ScrollBars.Vertical;
            if (cBoxNewline.Checked)
            {
                tBoxSendL.Text = Convert.ToString(tBoxSend.TextLength + 2);
            }
            else
            {
                tBoxSendL.Text = Convert.ToString(tBoxSend.TextLength);
            }
                
        }

        private void tBoxReceive_TextChanged(object sender, EventArgs e)
        {
            tBoxReceive.ScrollBars = ScrollBars.Vertical;
            tBoxReceiveL.Text = Convert.ToString(tBoxReceive.TextLength);
        }

        private void cBoxNewline_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxNewline.Checked)
            {
                tBoxSendL.Text = Convert.ToString(tBoxSend.TextLength + 2);
            }
            else
            {
                tBoxSendL.Text = Convert.ToString(tBoxSend.TextLength);
            }
        }

        private void bSendFile_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panel2.Show();
            else
                panel2.Hide();
            bAccept.Enabled = false;
            bReject.Enabled = false;
            bFileSend.Enabled = false;
            bSelectFile.Enabled = true;
            lFileName.Text = "Select File";
        }

        private void bSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OpenFile = openFileDialog.FileName;
                lFileName.Text = Path.GetFileName(OpenFile);
                bFileSend.Enabled = true;
            }
        }

        private void bFileSend_Click(object sender, EventArgs e)
        {
            SendBack = lFileName.Text + Convert.ToChar(5).ToString();
            serialPort1.Write(SendBack);
            progressBar1.Value = 1;
            lPercentage.Text = "1 %";
            bSendFile.Enabled = false;
            bFileSend.Enabled = false;
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            SendBack = Convert.ToChar(6).ToString();
            serialPort1.Write(SendBack);
            bAccept.Enabled = false;
            bReject.Enabled = false;
            progressBar1.Value = 2;
            lPercentage.Text = "2 %";
        }

        private void bReject_Click(object sender, EventArgs e)
        {
            SendBack = Convert.ToChar(7).ToString();
            serialPort1.Write(SendBack);
            bAccept.Enabled = false;
            bReject.Enabled = false;
            bSendFile.Enabled = true;
            progressBar1.Value = 0;
            lPercentage.Text = "0 %";
            flag *= -1;
            panel2.Hide();
        }

        private void cBoxDetails_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxDetails.Checked)
            {
                panel3.Hide();
            }
            else
            {
                panel3.Show();
            }
        }
    }
}
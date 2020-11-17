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
        int Delayms;

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


            cBoxComport.Items.AddRange(SerialPort.GetPortNames());
            serialPort1.NewLine = Convert.ToChar(1).ToString();
            bDisconnect.Enabled = false;
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
                Delayms = Convert.ToInt32(tBoxDelay.Text);

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
                tBoxDelay.Enabled = false;
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
                tBoxDelay.Enabled = true;

                Thread.Sleep(Delayms);
                if (cBoxRestart.Checked)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SendData = tBoxSend.Text;
                if (SendData.Length >= 4096)
                {
                    MessageBox.Show("The message is too large! Reduce the size and try again", "Character Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (cBoxNewline.Checked)
                    {
                        serialPort1.Write(Convert.ToChar(2).ToString());
                        Thread.Sleep(Delayms);
                        serialPort1.WriteLine(SendData);
                        Thread.Sleep(Delayms);
                        serialPort1.Write(Convert.ToChar(3).ToString());
                    }

                    else
                    {
                        serialPort1.Write(Convert.ToChar(2).ToString());
                        Thread.Sleep(Delayms);
                        serialPort1.Write(SendData);
                        Thread.Sleep(Delayms);
                        serialPort1.Write(Convert.ToChar(3).ToString());
                    }
                }
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
                Processing();
                elapsedms = stopwatch.ElapsedMilliseconds;
                if (elapsedms == 0)
                {
                    elapsedms = 1;
                }
                elapsedms -= Delayms * 2;
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
                SendBack = elapsedms + "/" + ReceiveDatal + Convert.ToChar(4).ToString();
                CalcRate();
                serialPort1.Write(SendBack);
                stopwatch.Reset();
                ReceiveData = "";
            }
            else if (ReceiveData.Contains(Convert.ToChar(4).ToString()))
            {
                ReceiveData = ReceiveData.Replace(Convert.ToChar(4).ToString(), "");
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
                ReceiveData = "";
            }
            //else
            //{
               // Processing();
            //}
            
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
                tBoxLength.Text = Convert.ToString(tBoxSend.TextLength + 2);
            }
            else
            {
                tBoxLength.Text = Convert.ToString(tBoxSend.TextLength);
            }
                
        }

        private void tBoxReceive_TextChanged(object sender, EventArgs e)
        {
            tBoxReceive.ScrollBars = ScrollBars.Vertical;
        }

        private void cBoxNewline_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxNewline.Checked)
            {
                tBoxLength.Text = Convert.ToString(tBoxSend.TextLength + 2);
            }
            else
            {
                tBoxLength.Text = Convert.ToString(tBoxSend.TextLength);
            }
        }
    }
}
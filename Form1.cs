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

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComport.Items.AddRange(ports);
            serialPort1.NewLine = "^";
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

                serialPort1.Open();
                lStatus.Text = "Connected";
                bConnect.Enabled = false;
                bDisconnect.Enabled = true;
                cBoxComport.Enabled = false;
                cBoxBaudrate.Enabled = false;
                cBoxDatabits.Enabled = false;
                cBoxStopbits.Enabled = false;
                cBoxParitybits.Enabled = false;


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
                serialPort1.Close();
                lStatus.Text = "Disconnected";
                bConnect.Enabled = true;
                bDisconnect.Enabled = false;
                cBoxComport.Enabled = true;
                cBoxBaudrate.Enabled = true;
                cBoxDatabits.Enabled = true;
                cBoxStopbits.Enabled = true;
                cBoxParitybits.Enabled = true;
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
                    stopwatch.Start();

                    if (cBoxNewline.Checked)
                    {
                        serialPort1.WriteLine(SendData);
                    }

                    else
                    {
                        serialPort1.Write(SendData);
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

            ReceiveData = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));

        }

        private void ShowData(object sender, EventArgs e)
        {
            if (ReceiveData.Contains("$"))
            {
                stopwatch.Stop();
                elapsedms = stopwatch.ElapsedMilliseconds;
                if (elapsedms == 0)
                {
                    elapsedms = 1;
                }
                lTime.Text = (elapsedms / 2).ToString() + " ms";
                ReceiveDatal = ReceiveData.Length - 1;
                lChar.Text = (ReceiveDatal).ToString();
                ReceiveDatal = ReceiveDatal * 8;
                elapseds = elapsedms / 2000;
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

                stopwatch.Reset();
            }
            else if (ReceiveData.Contains("^"))
            {
                if (cBoxCleardata.Checked || tBoxReceive.Text == "")
                {
                    ReceiveData = ReceiveData.Replace("^", "");
                    Output();
                }
                else
                {
                    ReceiveData = ReceiveData.Replace("^", "");
                    ReceiveData = string.Concat("" + System.Environment.NewLine, ReceiveData);
                    Output();
                }
            }
            else
            {
                Output();
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

                SendBack = ReceiveData += "$";
                serialPort1.Write(SendBack);

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
    }
}

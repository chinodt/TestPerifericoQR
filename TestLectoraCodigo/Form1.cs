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
using System.Runtime.InteropServices;
using System.Threading;

namespace TestLectoraCodigo
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);
        SerialPort ComPort = new SerialPort();
        [DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern uint WinExec(string lpCmdLine, uint uCmdShow);

        public Form1()
        {

            InitializeComponent();
            fillComboPorts();
            habiltaPort();

        }

        private void habiltaPort()
        {
            if (this.cboPuerto.Text != "")
            {
                ComPort.PortName = this.cboPuerto.Text;
                ComPort.BaudRate = 9600;
                ComPort.DataBits = 7;
                Thread.Sleep(1000);
                ComPort.DtrEnable = true;
                ComPort.Open();
                ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);
            }

        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            this.txtContent.Text = "";
        }

        private void SetText(string text)
        {
            this.txtContent.Text += text;
        }

        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(1000);
            string InputData = String.Empty;
            InputData = ComPort.ReadExisting();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
        }

        private void fillComboPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                csPorts csP = new csPorts();
                csP.Text = port;
                csP.Value = port;
                cboPuerto.Items.Add(csP);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboPuerto_SelectedIndexChanged(object sender, EventArgs e)
        {
            habiltaPort();
        }
    }

    public class csPorts
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

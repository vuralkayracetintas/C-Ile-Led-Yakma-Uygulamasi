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
namespace Led_yakma_uygulamasi
{
    public partial class Uygulama : Form
    {
        public Uygulama()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM5";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            label1.Text = "Led ON";
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            label1.Text = "Led OFF";
            button1.Enabled = true;
            button2.Enabled = false;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Close();
        }
    }
}

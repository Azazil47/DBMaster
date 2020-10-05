using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Program.ser.Refresh();
                MessageBox.Show(Program.ser.Status.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ser.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Program.ser.Status.ToString().Equals("Running"))
            {
                checkBox1.Checked = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.ser.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace DBMaster
{
    public partial class Form1 : Form
    {
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e) //Status
        {

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           foreach (String[] item in Program.listService)
            {
                dataGridView1.Rows.Add(item);
            }

           /* Thread gridThread = new Thread(new ThreadStart(Program.greedUpdate));
            gridThread.Start();*/////ПОТОК

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonStopAll_Click(object sender, EventArgs e)
        {
            ServiceClass.StopAll(Program.listService);
            //Program.LoadService();
            Program.greedUpdate();
            dataGridView1.Rows.Clear();
            foreach (String[] item in Program.listService)
            {
                dataGridView1.Rows.Add(item);
            }
        }

        private void buttonStartAll_Click(object sender, EventArgs e)
        {
            ServiceClass.StartAll(Program.listService);
            //Program.LoadService();
            Program.greedUpdate();
            dataGridView1.Rows.Clear();
            foreach (String[] item in Program.listService)
            {
                dataGridView1.Rows.Add(item);
            }
        }
    }
}

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
        
        public List<ServiceClass> listService = new List<ServiceClass>();
        
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void button2_Click(object sender, EventArgs e) //Status
        {
           MessageBox.Show(listService[0].Status()) ;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckBox checkBox1 = new CheckBox();
            checkBox1.Location = new Point(10, 10);
            listService.Add(new ServiceClass("FirebirdServerDefaultInstance"));
            checkBox1.Text = listService[0].getName();
            checkBox1.Width = 300;
            this.Controls.Add(checkBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceClass myserv = new ServiceClass("FirebirdServerDefaultInstance");
            myserv.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MyLoger.write("Hi, I'm Azazil!");
        }
    }
}

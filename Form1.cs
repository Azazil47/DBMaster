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
            listService.Add(new ServiceClass("FirebirdServerDefaultInstance"));
            checkBox1.Text = listService[0].getName();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}

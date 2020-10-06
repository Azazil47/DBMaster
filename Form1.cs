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


namespace DBMaster
{
    public partial class Form1 : Form
    {
        ServiceClass serv = new ServiceClass("FirebirdServerDefaultInstance");
        
        public List<ServiceClass> listService = new List<ServiceClass>();

        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e) //Status
        {
            serv.Refresh();
            MessageBox.Show(serv.Status().ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serv.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serv.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Services.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, serv);
                MessageBox.Show("Serializeble is good");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Services.dat", FileMode.OpenOrCreate))
            {
                ServiceClass serv = (ServiceClass)formatter.Deserialize(fs);
                MessageBox.Show("DeSerializeble is good");
               
                
            }
        }
    }
}

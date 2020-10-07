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
        
        
        
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e) //Status
        {
            //serv.Refresh();
            MessageBox.Show(ServiceClass.Status("FirebirdServerDefaultInstance").ToString());

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceClass.Stop("FirebirdServerDefaultInstance");
           // dataGridView1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadService();
            // listService.Add(new string[2] { "FirebirdServerDefaultInstance", $"{ServiceClass.Status("FirebirdServerDefaultInstance")}" });
            // listService.Add(new string[2] { "spooler", $"{ServiceClass.Status("spooler")}"});
            foreach (String[] item in Program.listService)
            {
                dataGridView1.Rows.Add(item);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceClass.Start("FirebirdServerDefaultInstance");
           // dataGridView1.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* BinaryFormatter formatter = new BinaryFormatter();
             using (FileStream fs = new FileStream("Services.dat", FileMode.OpenOrCreate))
             {
                 formatter.Serialize(fs, serv);
                 MessageBox.Show("Serializeble is good");
             }

             XmlSerializer formatter2 = new XmlSerializer(typeof(ServiceClass));
             using (FileStream fs2 = new FileStream("Sevices.xml", FileMode.OpenOrCreate))
             {
                 formatter.Serialize(fs2, serv);
                 MessageBox.Show("Serializeble is good XML");
             }*/
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (String[] item in Program.listService)
            {

                dataGridView1.Rows.Add(item);
            }
        }

        private void buttonStopAll_Click(object sender, EventArgs e)
        {
            ServiceClass.StopAll(Program.listService);
            dataGridView1.Rows.Clear();
            foreach (String[] item in Program.listService)
            {
                
                dataGridView1.Rows.Add(item);
            }
        }

        private void buttonStartAll_Click(object sender, EventArgs e)
        {
            ServiceClass.StartAll(Program.listService);
            dataGridView1.Rows.Clear();
            foreach (String[] item in Program.listService)
            {
                
                dataGridView1.Rows.Add(item);
            }
        }
    }
}

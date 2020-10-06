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
        public static List<String[]> listService = new List<String[]>();
        public static void LoadSrvice() //Загрузка списка служб из файла
        {
            try
            {
                using (StreamReader sr = new StreamReader("Services.ini", System.Text.Encoding.Default))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        
                        listService.Add(new string[2] {line, ServiceClass.Status(line).ToString()});
                    }
                }
                MessageBox.Show("Load is good");
            }
            catch (Exception)
            {

                MessageBox.Show("File is bad");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e) //Status
        {
            //serv.Refresh();
           // MessageBox.Show(serv.Status().ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceClass.Stop("FirebirdServerDefaultInstance");
            dataGridView1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSrvice();
           // listService.Add(new string[2] { "FirebirdServerDefaultInstance", $"{ServiceClass.Status("FirebirdServerDefaultInstance")}" });
           // listService.Add(new string[2] { "spooler", $"{ServiceClass.Status("spooler")}"});
            foreach (String[] item in listService)
            {
                dataGridView1.Rows.Add(item);
            }
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceClass.Start("FirebirdServerDefaultInstance");
            dataGridView1.Refresh();
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
           /* BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Services.dat", FileMode.OpenOrCreate))
            {
                ServiceClass serv = (ServiceClass)formatter.Deserialize(fs);
                MessageBox.Show("DeSerializeble is good");
               
                
            }*/
        }
    }
}

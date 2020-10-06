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
    [Serializable]
    public class Person
    {
        public String name;

        public Person() { }
        public Person(String name)
        {
            this.name = name;
        }
    }
    public partial class Form1 : Form
    {
        ServiceClass serv = new ServiceClass("FirebirdServerDefaultInstance");
        Person Ivan = new Person("Ivan");

        public List<ServiceClass> listService = new List<ServiceClass>();

        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e) //Status
        {
            listService[0].Refresh();
            MessageBox.Show(listService[0].Status());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listService[0].Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listService[0].Start();
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
    }
}

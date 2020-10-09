using System;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;


namespace DBMaster
{
    public partial class Form1 : Form
    {
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        public void greedUpdate()
        {
            Invoke((MethodInvoker)delegate ()
            {
                dataGridView1.Rows.Clear();
                foreach (String[] item in Program.listService)
                {
                    item[1] = new ServiceController(item[0]).Status.ToString();
                    dataGridView1.Rows.Add(item);
                }
            });
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
            Thread thread = new Thread(new ThreadStart(greedUpdate));
            thread.Start();
            /* Program.greedUpdate();
             dataGridView1.Rows.Clear();
             foreach (String[] item in Program.listService)
             {
                 dataGridView1.Rows.Add(item);
             }*/
        }

        private void buttonStartAll_Click(object sender, EventArgs e)
        {
            ServiceClass.StartAll(Program.listService);
            Thread thread = new Thread(new ThreadStart(greedUpdate));
            thread.Start();
            
            /*Program.greedUpdate();
            dataGridView1.Rows.Clear();
            foreach (String[] item in Program.listService)
            {
                dataGridView1.Rows.Add(item);
            }*/

        }
    }
}

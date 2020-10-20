using System;
using System.IO;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;


namespace DBMaster
{
    public partial class Form1 : Form
    {
        private String pathSDP;
        private String pathCopySDP;

        public void setTextBox(String line) //Метод вывода log на экран
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    textBoxLog.Text += line;
                }));
            }
            else
            {
                textBoxLog.Text += line;
            }
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

        public void pathSDPupdate(String path)
        {
            pathSDP = path;
            TbPathSDP.Text = pathSDP;
        }
        public void chekSDPfile()
        {
            String path = @"C:\Data\Justice\UNI_WORK2003.fdb";
            if (File.Exists(path))
            {
                pathSDPupdate(path);
            } else
            {
                pathSDPupdate("");
            }
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            greedUpdate();
            chekSDPfile();
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void buttonStopAll_Click(object sender, EventArgs e)
        {
            ServiceClass.StopAll(Program.listService);
        }

        private void buttonStartAll_Click(object sender, EventArgs e)
        {
            ServiceClass.StartAll(Program.listService);
        }

        private void BtBrowseSDP_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pathSDPupdate(openFileDialog1.FileName);
        }

        private void BtBrowseCopySDP_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
        }
    }
}

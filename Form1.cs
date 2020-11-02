using System;
using System.Data;
using System.IO;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;


namespace DBMaster
{
    public partial class Form1 : Form
    {
        public void setTextBox(String line) //Метод вывода log на экран для другого потока
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
        //ТЕСТОВЫЙ МЕТОД для прогресс бара

       public void updProgressBar(double persent)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    progressBarSDP.Value = (int)persent;
                }));
            } else
            {
                progressBarSDP.Value = (int)persent;
            }
        }
        public void greedUpdate() //Обновление списка служб в Greed
        {
            Invoke((MethodInvoker)delegate ()
            {
                dataGridView1.Rows.Clear();
                foreach (ServiceController item in Program.controllers)
                {
                   //string status  = new ServiceController(item).Status.ToString();
                   dataGridView1.Rows.Add(item.DisplayName, item.Status.ToString());
                }
            });
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            greedUpdate();
            
        }
       
        private void buttonStopAll_Click(object sender, EventArgs e) //Кнопка ОСТАНОВИТЬ все службы
        {
            ServiceClass.StopAll(Program.controllers);
        }

        private void buttonStartAll_Click(object sender, EventArgs e) // Кнопка ЗАПУСТИТЬ все службы
        {
            ServiceClass.StartAll(Program.controllers);
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            AddServicesForm servicesForm = new AddServicesForm();
            servicesForm.Show();
            
        }
        private void buttonCopySDP_Click(object sender, EventArgs e)
        {
            DbCopyForm formCopySDP = new DbCopyForm();
            formCopySDP.Show();
        }
    }
}

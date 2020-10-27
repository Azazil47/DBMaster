using System;
using System.IO;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;


namespace DBMaster
{
    public partial class Form1 : Form
    {
       /* private String pathSDP;
        public String PathSDP
        {
            get
            {
                return pathSDP;
            }
            set
            {
                pathSDP = value;
                UpdatePathSDP(value);
            }
        }*/

      /*  private String pathCopySDP;
        public String PathCopySDP
        {
            get
            {
                return pathCopySDP;
            }
            set
            {
                pathCopySDP = value;
                UpdatePathCopySDP(value);
            }
        }*/
        /*public void UpdatePathSDP(String path)// заполнение поля где лежит SDP
        {
            TbPathSDP.Text = path;
        }*/
        /*public void UpdatePathCopySDP(String path) // заполнение поля куда копировать базу SDP
        {
            TbCopySDP.Text = path;
        }*/
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
                foreach (String[] item in Program.listService)
                {
                    item[1] = new ServiceController(item[0]).Status.ToString();
                    dataGridView1.Rows.Add(item);
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
            //chekSDPfile();
        }
       
        private void buttonStopAll_Click(object sender, EventArgs e) //Кнопка ОСТАНОВИТЬ все службы
        {
            ServiceClass.StopAll(Program.listService);
        }

        private void buttonStartAll_Click(object sender, EventArgs e) // Кнопка ЗАПУСТИТЬ все службы
        {
            ServiceClass.StartAll(Program.listService);
        }

      /*  private void BtBrowseSDP_Click(object sender, EventArgs e) // Кнопка ОБЗОРА файла БД
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            PathSDP = openFileDialog1.FileName;
        }*/

      /*  private void BtBrowseCopySDP_Click(object sender, EventArgs e) //Кнопка обзора куда созранить копию БД
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            PathCopySDP = saveFileDialog1.FileName;
        }*/

       /* private void BtCopySDP_Click(object sender, EventArgs e) //КНОПКА КОПИРОВАНИЯ ФАЙЛА Копирование присходит в отдельном потоке
        {
            CopyClass copy = new CopyClass();
            
            var thread = new Thread(() => copy.Copy(PathSDP, pathCopySDP));
            thread.Start();

        }*/

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonCopySDP_Click(object sender, EventArgs e)
        {
            DbCopyForm formCopySDP = new DbCopyForm();
            formCopySDP.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;

namespace DBMaster
{
    public partial class AddServicesForm : Form
    {
        private static ServiceController[] list = ServiceController.GetServices();
        public void filterServices()
        {
            string finde = textBox1.Text;
            dataGvServices.Rows.Clear();
            foreach (ServiceController item in list)
            {
                if (item.DisplayName.ToString().Contains(finde))
                {
                    dataGvServices.Rows.Add(item.DisplayName, item.Status);
                }
            }
        }
        public AddServicesForm()
        {
            InitializeComponent();
        }

        private void AddServicesForm_Load(object sender, EventArgs e)//Получение всего списка служб при первом вызове окна
        {
            
           
            foreach (ServiceController item in list)
            {
                dataGvServices.Rows.Add(item.DisplayName, item.Status);
            }
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filterServices();
        }
    }
}

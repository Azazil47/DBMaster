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
        public AddServicesForm()
        {
            InitializeComponent();
        }

        private void AddServicesForm_Load(object sender, EventArgs e)
        {
            ServiceController[] list = ServiceController.GetServices();
            DataTable serviceTable = new DataTable("ServicesTabel");
            dataSet1.Tables.Add(serviceTable);
            //-------------------------------------------------------------------------
            DataColumn idServices = new DataColumn("id", Type.GetType("System.Int32"));
            idServices.Unique = true;
            idServices.AllowDBNull = false;
            idServices.AutoIncrement = true;
            idServices.AutoIncrementSeed = 1;
            idServices.AutoIncrementStep = 1;
            //-------------------------------------------------------------------------
            DataColumn nameServices = new DataColumn("Name", Type.GetType("System.String"));
            //-------------------------------------------------------------------------
            DataColumn statusServices = new DataColumn("Status", Type.GetType("System.String"));
            //-------------------------------------------------------------------------
            serviceTable.Columns.Add(idServices);
            serviceTable.Columns.Add(nameServices);
            serviceTable.Columns.Add(statusServices);
            //-------------------------------------------------------------------------
            serviceTable.PrimaryKey = new DataColumn[] { serviceTable.Columns["id"] };
            foreach (ServiceController service in list)
            {
                serviceTable.Rows.Add(new object[] { null, service.ServiceName, service.Status.ToString() });

            }
            dataGridView1.DataSource = dataSet1.Tables[0];

        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.ServiceProcess;

namespace DBMaster
{

    static class Program
    {
        public static Form1 myForm;
        public static List<String> listService = new List<String>();
        public static List<ServiceController> controllers = new List<ServiceController>();

        public static void getService()
        {
           string services = Properties.Settings.Default._serviceList;
           string[] list = services.Split();
           foreach (string item in list)
           {
                controllers.Add(new ServiceController(item));
           }

        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            getService();
            //LoadService();
            myForm = new Form1();
            Application.Run(myForm);
        }
    }
}

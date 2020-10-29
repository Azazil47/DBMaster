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

        public static void getService()
        {
           string Services = Properties.Settings.Default._serviceList;
           string[] list = Services.Split();
           foreach (string item in list)
           {
                listService.Add(item);
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

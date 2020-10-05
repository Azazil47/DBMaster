using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ServiceProcess;

namespace DBMaster
{
    
    static class Program
    {
        public static ServiceController ser = new ServiceController("FirebirdServerDefaultInstance"); 

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Form1());
           
            

    }
    }
}

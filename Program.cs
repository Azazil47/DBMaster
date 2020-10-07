using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ServiceProcess;
using System.IO;

namespace DBMaster
{
    
    static class Program
    {
        public static Form1 myForm;
        public static List<String[]> listService = new List<String[]>();
        public static void LoadService() //Загрузка списка служб из файла
        {
            try
            {
                using (StreamReader sr = new StreamReader("Services.ini"))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listService.Add(new string[2] { line, ServiceClass.Status(line) });
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("File is bad");
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
            LoadService();
            myForm = new Form1();
            Application.Run(myForm);
    }
    }
}

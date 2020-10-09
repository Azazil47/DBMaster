﻿using System;
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
                        listService.Add(new string[2] { line, new ServiceController(line).Status.ToString() });
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить некоторые службы из файла Services.ini");
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

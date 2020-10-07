﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ServiceProcess;
using System.IO;
using System.Threading;

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

        public static void RefreshList()
        {
            foreach (String[] item in listService)
            {
                item[1] = ServiceClass.Status(item[0]);
            }
        }

        public static void greedUpdate()
        {
            foreach (String[] item in listService)
            {
                item[1] = ServiceClass.Status(item[0]);
            }
        }

      /* public static void greedUpdate()
        {
            MessageBox.Show("Thread");
            while (true)
            {
               /* foreach (String[] item in listService)
                {
                    item[1] = ServiceClass.Status(item[0]);
                }
                myForm.dataGridView1.Rows.Clear();
                foreach (String[] item in listService)
                {
                    myForm.dataGridView1.Rows.Add(item);
                }*/
                
            
        


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

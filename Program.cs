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
        public static List<ServiceController> controllers = new List<ServiceController>();

        public static void getService()//Десереализация с проверкой корректности служб (нужно переделать для записи в лог без страшных исключений)
        {
           string services = Properties.Settings.Default._serviceList;
            if (services != "")
            {
                string[] list = services.Split();
                foreach (string item in list)
                {
                    using (ServiceController sc = new ServiceController(item))
                    {
                        try
                        {
                            if (sc.Status != ServiceControllerStatus.Running)
                            {
                                sc.Start();
                                sc.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(0, 0, 10));
                                //service is now Started    
                                controllers.Add(new ServiceController(item));
                                
                            }
                            else
                            {
                                controllers.Add(new ServiceController(item));
                                
                                //Service was already started
                            }
                        }
                        catch (System.ServiceProcess.TimeoutException e)
                        {
                            MessageBox.Show(e.ToString());
                            //Service was stopped but could not restart (10 second timeout)
                        }
                        catch (InvalidOperationException e)
                        {
                            MessageBox.Show(e.ToString());
                            //This Service does not exist       
                        }
                    }
                }
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
            myForm = new Form1();
            Application.Run(myForm);
        }
    }
}

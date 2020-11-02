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
       // public static List<String> listService = new List<String>(); Старый список больше не используется
        public static List<ServiceController> controllers = new List<ServiceController>();

        public static void getService()
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
                                controllers.Add(sc);
                            }
                            else
                            {
                                controllers.Add(sc);
                                //Service was already started
                            }
                        }
                        catch (System.ServiceProcess.TimeoutException)
                        {
                            //Service was stopped but could not restart (10 second timeout)
                        }
                        catch (InvalidOperationException)
                        {
                            MessageBox.Show("This Service does not exist");
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
            //LoadService();
            myForm = new Form1();
            Application.Run(myForm);
        }
    }
}

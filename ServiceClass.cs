using DBMaster;
using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

public static class ServiceClass // : ServiceController
{
    public static void Start(object name)
    {
       // String name = (String)setname;
        ServiceController service = (ServiceController) name;
        try
        {
            if(service.Status.Equals(ServiceControllerStatus.Stopped))
            {
                service.Start();
                int sec = 30;
                while (!service.Status.Equals(ServiceControllerStatus.Running)) //Ожидание изменения статуса службы
                {
                    Thread.Sleep(1000);
                    service.Refresh();
                    if (sec-- == 0) break;
                }
                Program.myForm.greedUpdate();
                if (sec > 0)
                { //GOOD
                    MyLoger.writeFile(0, "служба", service.DisplayName, service.Status);
                    MyLoger.writeTextBox(0, "служба", service.DisplayName, service.Status);
                }
                else
                { //FAILT
                    MyLoger.writeFile(-1, "служба", service.DisplayName, service.Status);
                    MyLoger.writeTextBox(-1, "служба", service.DisplayName, service.Status);
                }
            }else
            {
                MyLoger.writeFile(-1, "служба", "xxx", "не может быть остановлена");// xxx
                MyLoger.writeTextBox(-1, "служба", "xxx", "не может быть остановлена");//xxx
            }
        }
        catch (Exception)
        {
            MessageBox.Show($"Со этой службой \"xxx\", что-то не так.", "Предупреждение");//xxx
            MyLoger.writeFile(-1, "служба", "xxx", "не может быть остановлена");//xxx
            MyLoger.writeTextBox(-1, "служба", "xxx", "не может быть остановлена");//xxx
        }
        
    }

    public static void Stop(object name)
    {
        //String name = (String)setname;
        ServiceController service = (ServiceController)name;
        try
        {
            if(service.Status.Equals(ServiceControllerStatus.Running))
                { 
                service.Stop();
                int sec = 30;
                while (!service.Status.Equals(ServiceControllerStatus.Stopped)) //Ожидание изменения статуса службы
                {
                    Thread.Sleep(1000);
                    service.Refresh();
                    if (sec-- == 0) break;
                }
                Program.myForm.greedUpdate();
                if (sec > 0)
                { //GOOD
                    MyLoger.writeFile(0, "служба", service.DisplayName, service.Status);
                    MyLoger.writeTextBox(0, "служба", service.DisplayName, service.Status);
                }
                else
                { //FAILT
                    MyLoger.writeFile(-1, "служба", service.DisplayName, service.Status);
                    MyLoger.writeTextBox(-1, "служба", service.DisplayName, service.Status);
                }
            } else
            {
                MyLoger.writeFile(-1, "служба", "xxx", "не может быть остановлена");//xxx
                MyLoger.writeTextBox(-1, "служба", "xxx", "не может быть остановлена");//xxx
            }
        }
        catch (Exception)
        {
            MessageBox.Show($"Со этой службой \"xxx\", что-то не так.", "Предупреждение");//xxx
            MyLoger.writeFile(-1, "служба", "xxx", "не может быть остановлена");//xxx
            MyLoger.writeTextBox(-1, "служба", "xxx", "не может быть остановлена");//xxx
        }
    }

    public static void StopAll(List<ServiceController> list)
    {
        foreach (ServiceController item in list)
        {
            Thread thread = new Thread(Stop);
            thread.Start(item);
        }
    }

    public static void StartAll(List<ServiceController> list)
    {
        foreach (ServiceController item in list)
        {
            Thread thread = new Thread(Start);
            thread.Start(item);
        }
    }
    
    public static Boolean ChekServices(List<ServiceController> list)
    {
        Boolean flag = false;
        foreach (ServiceController item in list)
        {
            if (!item.Status.Equals(ServiceControllerStatus.Stopped))
            {
                flag = true;
            }
        }
        return flag;
    }
}


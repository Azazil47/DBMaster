using DBMaster;
using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

public static class ServiceClass // : ServiceController
{
    public static void Start(Object setname)
    {
        String name = (String)setname;
        ServiceController service = new ServiceController(name);
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
                MyLoger.writeFile(-1, "служба", name, "не может быть остановлена");
                MyLoger.writeTextBox(-1, "служба", name, "не может быть остановлена");
            }
        }
        catch (Exception)
        {
            MessageBox.Show($"Со этой службой \"{name}\", что-то не так.", "Предупреждение");
            MyLoger.writeFile(-1, "служба", name, "не может быть остановлена");
            MyLoger.writeTextBox(-1, "служба", name, "не может быть остановлена");
        }
        
    }

    public static void Stop(Object setname)
    {
        String name = (String)setname;
        ServiceController service = new ServiceController(name);
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
                MyLoger.writeFile(-1, "служба", name, "не может быть остановлена");
                MyLoger.writeTextBox(-1, "служба", name, "не может быть остановлена");
            }
        }
        catch (Exception)
        {
            MessageBox.Show($"Со этой службой \"{name}\", что-то не так.", "Предупреждение");
            MyLoger.writeFile(-1, "служба", name, "не может быть остановлена");
            MyLoger.writeTextBox(-1, "служба", name, "не может быть остановлена");
        }
    }

    public static void StopAll(List<String[]> list)
    {
        foreach (String[] item in list)
        {
            Thread thread = new Thread(Stop);
            thread.Start(item[0]);
        }
    }

    public static void StartAll(List<String[]> list)
    {
        foreach (String[] item in list)
        {
            Thread thread = new Thread(Start);
            thread.Start(item[0]);
        }
    }
}


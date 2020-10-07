using DBMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

public static class ServiceClass // : ServiceController
{
    public static void Start(String name)
    {
        ServiceController service = new ServiceController(name);
        try
        {
            if (Status(name).Equals("Stopped"))
            {

                service.Start();
                MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба {service.DisplayName}\tСтатус: ЗАПУСКАЕТСЯ");
                Program.myForm.textBoxLog.Text += $"{ DateTime.Now.ToString("HH:mm:ss")} - {MyLoger.MyEnum.INFO} Служба \"{service.DisplayName}\": ЗАПУСКАЕТСЯ\r\n";
                Thread.Sleep(1000);
                service.Refresh();
            }
            else if ((Status(name).Equals("Running")) || (Status(name).Equals("StartPending")))
            {
                MyLoger.write($"{MyLoger.MyEnum.WARNING}\tСлужба \"{service.DisplayName}\" не может быть запущена");
                Program.myForm.textBoxLog.Text += $"{DateTime.Now.ToString("HH:mm:ss")} - {MyLoger.MyEnum.WARNING} Служба \"{service.DisplayName}\" не может быть запущена\r\n";
            }
            else
            {
                MyLoger.write($"{MyLoger.MyEnum.WARNING}\tСлужба \"{name}\" не может быть запущена");
                Program.myForm.textBoxLog.Text += $"{DateTime.Now.ToString("HH:mm:ss")} - {MyLoger.MyEnum.WARNING} Служба \"{name}\" не может быть запущена\r\n";
            }
        }
        catch (Exception)
        {
            MessageBox.Show($"\"{service.DisplayName}\" cлужба не смогла поднятся с колен");
            MyLoger.write($"{MyLoger.MyEnum.ERROR}\t Попытка запустить службу \"{service.DisplayName}\" привела к страшным последствиям");
        }


    }

    public static void Stop(String name)
    {
        ServiceController service = new ServiceController(name);
        try
        {
            if (Status(name).Equals("Running"))
            {
                service.Stop();
                MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба \"{service.DisplayName}\"\tСтатус: ОСТАНАВЛИВАЕТСЯ");
                Program.myForm.textBoxLog.Text += $"{DateTime.Now.ToString("HH:mm:ss")} - {MyLoger.MyEnum.INFO} Служба \"{service.DisplayName}\" Статус: ОСТАНАВЛИВАЕТСЯ\r\n";
                Thread.Sleep(1000);
                service.Refresh();
            }
            else if ((Status(name).Equals("Stopped")) || (Status(name).Equals("StopPending")))
            {
                MyLoger.write($"{MyLoger.MyEnum.WARNING}\tСлужба \"{service.DisplayName}\" не может быть остановлена");
                Program.myForm.textBoxLog.Text += $"{DateTime.Now.ToString("HH:mm:ss")} - {MyLoger.MyEnum.WARNING} Служба \"{service.DisplayName}\" не может быть остановлена\r\n";
            }
            else
            {
                MyLoger.write($"{MyLoger.MyEnum.WARNING}\tСлужба \"{name}\" не может быть остановлена");
                Program.myForm.textBoxLog.Text += $"{DateTime.Now.ToString("HH:mm:ss")} - {MyLoger.MyEnum.WARNING} Служба \"{name}\" не может быть остановлена\r\n";
            }
        }
        catch (Exception)
        {
            MessageBox.Show($"\"{service.DisplayName}\" cлужба не смогла остановится");
            MyLoger.write($"{MyLoger.MyEnum.ERROR}\t Попытка остановить службу \"{service.DisplayName}\" привела к страшным последствиям");
        }

    }

    public static void StopAll(List<String[]> list)
    {
        foreach (String[] item in list)
        {
            Stop(item[0]);
        }
    }

    public static void StartAll(List<String[]> list)
    {
        foreach (String[] item in list)
        {
            Start(item[0]);
        }

    }


    public static String Status(String name)
    {
        ServiceController service = new ServiceController(name);
        try
        {
            service.Refresh();
            MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба: {service.DisplayName} \tСтатус: {service.Status.ToString()}");
            return service.Status.ToString();
        }
        catch (Exception)
        {
            return "Служба не найдена";
        }
    }

    public static void Refresh(String name)
    {
        ServiceController service = new ServiceController(name);

        service.Refresh();
    }


}


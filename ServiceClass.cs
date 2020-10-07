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
            if (!service.Status.Equals("Running"))
            {
                service.Start();
                MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба {service.DisplayName}\tСтатус: ЗАПУСКАЕТСЯ");
                Program.myForm.textBoxLog.Text = $"{MyLoger.MyEnum.INFO}\tСлужба {service.DisplayName}\tСтатус: ЗАПУСКАЕТСЯ\n";
                Thread.Sleep(1000);
                service.Refresh();
            } else
            {
                MyLoger.write($"{MyLoger.MyEnum.WARNING}\tСлужба {service.DisplayName} уже запущена");
            }
        }
        catch (Exception)
        {
            MessageBox.Show($"{service.DisplayName} cлужба не смогла поднятся с колен");
            MyLoger.write($"{MyLoger.MyEnum.ERROR}\t Попытка запустить службу {service.DisplayName} привела к страшным последствиям");
        }
        

    }

    public static void Stop(String name)
    {
        ServiceController service = new ServiceController(name);
        try
        {
            if (!service.Status.Equals("Stopped"))
            {
                service.Stop();
                MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба {service.DisplayName}\tСтатус: ОСТАНАВЛИВАЕТСЯ");
                Thread.Sleep(1000);
                service.Refresh();
            }
            else
            {
                MyLoger.write($"{MyLoger.MyEnum.WARNING}\tСлужба {service.DisplayName} уже остановлена");
            }
        }
        catch (Exception)
        {
            MessageBox.Show($"{service.DisplayName} cлужба не смогла остановится");
            MyLoger.write($"{MyLoger.MyEnum.ERROR}\t Попытка остановить службу {service.DisplayName} привела к страшным последствиям");
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


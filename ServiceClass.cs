using DBMaster;
using System;
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
                Thread.Sleep(1000);
                service.Refresh();
            } else
            {
                MyLoger.write($"{MyLoger.MyEnum.WARNING}\tСлужба {service.DisplayName} уже запущена");
            }
        
        
        }
        catch (Exception)
        {
            MessageBox.Show("Служба не смогла поднятся с колен");
            MyLoger.write($"{MyLoger.MyEnum.ERROR}\t Попытка запустить службу {service.DisplayName} привела к страшным последствиям");
        }
        

    }

    public static void Stop(String name)
    {
        ServiceController service = new ServiceController(name);
        service.Stop();
        MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба {service.DisplayName}\tСтатус: ОСТАНАВЛИВАЕТСЯ");
        Thread.Sleep(1000);
        service.Refresh();
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


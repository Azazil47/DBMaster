using DBMaster;
using System;
using System.Linq;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

[Serializable]
public static class ServiceClass // : ServiceController
{
    public static void Start(String name)
    {
        ServiceController service = new ServiceController(name);
        service.Start();
        MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба {service.DisplayName}\tСтатус: ЗАПУСКАЕТСЯ");
        Thread.Sleep(1000);

        service.Refresh();
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

        ServiceController SC = new ServiceController(name);
       

         ServiceController service = new ServiceController(name);
             service.Refresh();
             MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба: {service.DisplayName} \tСтатус: {service.Status.ToString()}");
             return service.Status.ToString();




    }

    public static void Refresh(String name)
    {
        ServiceController service = new ServiceController(name);
        service.Refresh();
    }

    
}


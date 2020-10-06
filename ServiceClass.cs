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
        bool ServiceIsInstalled = false;
        try
        {
            // actually we need to try access ANY of service properties
            // at least once to trigger an exception
            // not neccessarily its name
            string ServiceName = SC.DisplayName;
            ServiceIsInstalled = true;
            return SC.Status.ToString(); 
        }
        catch (InvalidOperationException) { }
        finally
        {
             
             SC.Close();
        }
        return SC.Status.ToString();

        /* ServiceController service = new ServiceController(name);
             service.Refresh();
             MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба: {service.DisplayName} \tСтатус: {service.Status.ToString()}");
             return service.Status.ToString();*/




    }

    public static void Refresh(String name)
    {
        ServiceController service = new ServiceController(name);
        service.Refresh();
    }

    
}


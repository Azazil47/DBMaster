using DBMaster;
using System;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

[Serializable]
public class ServiceClass : ServiceController
{
    public String name;
    public ServiceClass(String name)
    {
        base.ServiceName = name;
        this.name = name;
    }

    public ServiceClass() { }
    public new void Start()
    {
        base.Start();
        MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба {base.DisplayName}\tСтатус: ЗАПУСКАЕТСЯ");
        Thread.Sleep(1000);
        this.Refresh();
    }

    public new void Stop()
    {
        base.Stop();
        MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба {base.DisplayName}\tСтатус: ОСТАНАВЛИВАЕТСЯ");
        Thread.Sleep(1000);
        this.Refresh();
    }

    public new String Status()
    {
        base.Refresh();
        return base.Status.ToString();
    }

    public new void Refresh()
    {
        base.Refresh();
        MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба {base.DisplayName}\tСтатус: {base.Status.ToString()}");
    }
}


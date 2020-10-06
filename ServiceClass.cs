using DBMaster;
using System;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

[Serializable]
public class ServiceClass // : ServiceController
{
    //public String name;
    [NonSerialized]
    public ServiceController name;
    public ServiceClass(String name)
    {
        //base.ServiceName = name;
        this.name = new ServiceController(name);
    }

    public ServiceClass() { }
    public void Start()
    {
        this.name.Start();
        MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба {this.name.DisplayName}\tСтатус: ЗАПУСКАЕТСЯ");
        Thread.Sleep(1000);
        
        this.name.Refresh();
    }

    public void Stop()
    {
        this.name.Stop();
        MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба {this.name.DisplayName}\tСтатус: ОСТАНАВЛИВАЕТСЯ");
        Thread.Sleep(1000);
        this.name.Refresh();
    }

    public String Status()
    {
        this.name.Refresh();
        MyLoger.write($"{MyLoger.MyEnum.INFO}\tСлужба: {this.name.DisplayName} \tСтатус: {this.name.Status.ToString()}");

        return this.name.Status.ToString(); 
    }

    public void Refresh()
    {
        this.name.Refresh();
    }

    
}


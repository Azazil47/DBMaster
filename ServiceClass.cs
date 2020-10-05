using System;
using System.ServiceProcess;
using System.Windows.Forms;

public class ServiceClass : ServiceController
{
    public ServiceClass(String name)
    {
        base.ServiceName = name;
    }
    public new void Start()
    {
        base.Start();
        MessageBox.Show("OK");
    }

    public new void Stop()
    {
        base.Stop();
        MessageBox.Show("OK");
    }

    public new String Status()
    {
        base.Refresh();
        return base.Status.ToString();
    }

    public String getName()
    {
        return base.DisplayName;
    }



}


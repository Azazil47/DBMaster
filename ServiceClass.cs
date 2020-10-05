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

		public new  void Stop() 
    {
		base.Stop();
		MessageBox.Show("OK");
		

	}

	public new void Refresh()
    {
		base.Refresh();
		MessageBox.Show("Refresh");
    }

	public String Status()
    {
	return	base.Status.ToString();
    }

	public String getName()
    {
		return base.DisplayName;
    }

		

	}


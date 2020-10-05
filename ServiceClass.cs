using System;
using System.ServiceProcess;
using System.Windows.Forms;

public class ServiceClass : ServiceController
	{
		private ServiceController nameService;
		public ServiceClass(String name)
		{
		this.nameService = new ServiceController(name);
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
	return	this.nameService.Status.ToString();
    }

	public String getName()
    {
		return this.nameService.DisplayName;
    }

		

	}


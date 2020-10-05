using System;
using System.ServiceProcess;
using System.Windows.Forms;

public class ServiceClass : ServiceController
	{
		private ServiceController nameService;
		public ServiceClass(String name)
		{
		this.nameService = new ServiceController(name);
		}
		public void Start()
		{
		
		//this.nameService.Start();
		MessageBox.Show("OK");
		}

		public  void Stop() 
    {
		
		MessageBox.Show("OK");
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


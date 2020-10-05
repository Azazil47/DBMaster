using System;
using System.ServiceProcess;

	public class ServiceClass
	{
		private ServiceController nameService;
		public ServiceClass(String name)
		{
		this.nameService = new ServiceController(name);
		}
		public void Start()
		{
		this.nameService.Start();
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


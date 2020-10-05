using System;
using System.ServiceProcess;

	public class ServiceClass
	{
		private ServiceController nameService;
		public ServiceClass(String name)
		{
		this.nameService = new ServiceController(name);
		}
		public void Start(String name)
		{
		this.nameService.Start();
		}

	}


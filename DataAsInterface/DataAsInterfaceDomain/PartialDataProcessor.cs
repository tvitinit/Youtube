using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAsInterfaceDomain
{
	public class PartialDataProcessor
	{
		private readonly IService _service;

		public PartialDataProcessor(IService service)
		{
			_service = service;
		}

		public void Process()
		{
			var data = _service.Get();

			data.Property1 += "Modified"; 
			data.Property2 += "Modified"; 
			data.Property3 += "Modified"; 
			data.Property4 += "Modified"; 
			data.Property5 += "Modified"; 
			data.Property6 += "Modified"; 
			data.Property7 += "Modified";

			Console.WriteLine(data);
		}
	}
}

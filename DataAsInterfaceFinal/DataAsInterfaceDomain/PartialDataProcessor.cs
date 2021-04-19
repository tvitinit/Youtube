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
			var data = Convert(_service.Get());

			data.Property1 += "Modified"; 
			data.Property2 += "Modified"; 
			data.Property3 += "Modified"; 
			data.Property4 += "Modified"; 
			data.Property5 += "Modified"; 
			data.Property6 += "Modified"; 
			data.Property7 += "Modified";

			Console.WriteLine(data);
		}

		private SmallData Convert(BigData bigData)
		{
			return new SmallData
			{
				Property1 = bigData.Property1,
				Property2 = bigData.Property2,
				Property3 = bigData.Property3,
				Property4 = bigData.Property4,
				Property5 = bigData.Property5,
				Property6 = bigData.Property6,
				Property7 = bigData.Property7,
			};
		}
	}
}

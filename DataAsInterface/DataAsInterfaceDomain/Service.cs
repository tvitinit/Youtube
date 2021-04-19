using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAsInterfaceDomain
{
	public class Service : IService
	{
		public BigData Get()
		{
			return new BigData
			{
				Property1 = "Property1",
				Property2 = "Property2",
				Property3 = "Property3",
				Property4 = "Property4",
				Property5 = "Property5",
				Property6 = "Property6",
				Property7 = "Property7",
				ExtraProperty1 = "ExtraProperty1",
				ExtraProperty2 = "ExtraProperty2",
				ExtraProperty3 = "ExtraProperty3"
			};
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsInside
{
	public class SubProcessor : ISubProcessor
	{
		private readonly IServiceOne _serviceOne;
		private readonly IServiceTwo _serviceTwo;

		public SubProcessor(IServiceOne serviceOne, IServiceTwo serviceTwo)
		{
			_serviceOne = serviceOne;
			_serviceTwo = serviceTwo;
		}

		public DataObject SubCalculate(DataObject dataObject)
		{
			var value = dataObject.Value;

			value = _serviceOne.GetValue(value);
			value = _serviceTwo.GetValue(value);
			return new DataObject { Value = value };
		}
	}
}

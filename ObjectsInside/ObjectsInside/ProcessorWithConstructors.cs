using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsInside
{
	public class ProcessorWithConstructors
	{
		private readonly ISubProcessor _subProcessor;

		//bad constructor - no DI
		public ProcessorWithConstructors()
		{
			_subProcessor = new SubProcessor(new ServiceOne(), new ServiceTwo());
		}

		//bad constructor - mixing DI with direct construction - probably worst
		public ProcessorWithConstructors(IServiceOne serviceOne, IServiceTwo serviceTwo)
		{
			_subProcessor = new SubProcessor(serviceOne, serviceTwo);
		}

		//good contructor - DI with correct dependencies
		public ProcessorWithConstructors(ISubProcessor subProcessor)
		{
			_subProcessor = subProcessor;
		}

		public DataObject Calculate(DataObject dataObject)
		{
			var data = _subProcessor.SubCalculate(dataObject);
			return data;
		}

	}
}

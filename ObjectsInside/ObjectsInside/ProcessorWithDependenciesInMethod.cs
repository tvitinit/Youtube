using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsInside
{
	public class ProcessorWithDependenciesInMethod
	{
		private readonly Func<ISubProcessor> _subProcessorFunc;

		public ProcessorWithDependenciesInMethod(Func<ISubProcessor> subProcessorFunc)
		{
			_subProcessorFunc = subProcessorFunc;
		}

		public ProcessorWithDependenciesInMethod()
		{
		}

		//super extremely bad
		public DataObject Calculate(DataObject dataObject)
		{
			var subProcessor = new SubProcessor(new ServiceOne(), new ServiceTwo());

			var data = subProcessor.SubCalculate(dataObject);
			return data;
		}

		// for dynamic creation
		public DataObject CalculateGood(DataObject dataObject)
		{
			var subProcessor = _subProcessorFunc();

			var data = subProcessor.SubCalculate(dataObject);
			return data;
		}
	}
}

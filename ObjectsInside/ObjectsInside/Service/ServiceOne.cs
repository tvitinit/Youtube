using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsInside
{
	public class ServiceOne : IServiceOne
	{
		public int GetValue(int data)
		{
			return data++;
		}

	}
}

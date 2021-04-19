using DataAsInterfaceDomain;
using System;

namespace DataAsInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			var procesor = new PartialDataProcessor(new Service());
			procesor.Process();
		}
	}
}

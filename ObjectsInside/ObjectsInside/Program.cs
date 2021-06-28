using System;

namespace ObjectsInside
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var processorWithConstrustor = new ProcessorWithConstructors();
			var data = new DataObject { Value = 1 };
			var result = processorWithConstrustor.Calculate(data);
			Console.WriteLine($"Value after first run: {result.Value}");

			var processorWithDependenciesInMethod = new ProcessorWithDependenciesInMethod();
			result = processorWithDependenciesInMethod.Calculate(result);
			Console.WriteLine($"Value after first run: {result.Value}");
		}
	}
}

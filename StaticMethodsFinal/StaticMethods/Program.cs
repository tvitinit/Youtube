using System;

namespace StaticMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			var calculator = new WordStatisticsCalculator(new CalculatorHelpers());
			var stats = calculator.CalculateStatistics("Bla bla. This is a text. And this is another text as well");
			Console.WriteLine(stats);
		}
	}
}

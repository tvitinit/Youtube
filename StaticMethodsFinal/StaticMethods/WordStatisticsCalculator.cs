using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
	public class WordStatisticsCalculator
	{
		private readonly ICalculatorHelpers _calculatorHelpers;

		public WordStatisticsCalculator(ICalculatorHelpers calculatorHelpers)
		{
			_calculatorHelpers = calculatorHelpers;
		}

		public WordStatistics CalculateStatistics(string text)
		{
			var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			var sentences = text.Split('.', StringSplitOptions.RemoveEmptyEntries);

			var stats = new WordStatistics
			{
				AverageWordCountInSentence = _calculatorHelpers.CalculateAverageWordCountInSentence(sentences),
				AverageWordLength = _calculatorHelpers.CalculateAverageWordLength(words),
				TotalWords = _calculatorHelpers.CalculateTotalWords(words)
			};

			return stats;
		}

	}
}

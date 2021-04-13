using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
	public class WordStatisticsCalculator
	{
		public WordStatistics CalculateStatistics(string text)
		{
			var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			var sentences = text.Split('.', StringSplitOptions.RemoveEmptyEntries);

			var stats = new WordStatistics
			{
				AverageWordCountInSentence = CalculatorHelpers.CalculateAverageWordCountInSentence(sentences),
				AverageWordLength = CalculatorHelpers.CalculateAverageWordLength(words),
				TotalWordsAndSentences = CalculatorHelpers.CalculateTotalWords(words)
			};

			return stats;
		}

	}
}

using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StaticMethods.Tests
{
	public class WordStatisticsCalculatorTests
	{
		[Fact]
		public void CalculateStatistics_ForSingleSentence()
		{
			var text = "This is a sentence";
			var calculator = new WordStatisticsCalculator();
			var result = calculator.CalculateStatistics(text);
			result.TotalWordsAndSentences.ShouldBe(4);
			result.AverageWordLength.ShouldBe(3);
			result.AverageWordCountInSentence.ShouldBe(4);
		}

		[Fact]
		public void CalculateStatistics_ForMultiSentence()
		{
			var text = "This is a sentence. And this is another sentence with words";
			var calculator = new WordStatisticsCalculator();
			var result = calculator.CalculateStatistics(text);
			result.TotalWordsAndSentences.ShouldBe(11);
			result.AverageWordLength.ShouldBe(4);
			result.AverageWordCountInSentence.ShouldBe(5);
		}
	}
}

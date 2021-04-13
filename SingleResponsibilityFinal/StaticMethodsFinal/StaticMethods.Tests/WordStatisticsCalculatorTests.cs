using Moq;
using Shouldly;
using Xunit;

namespace StaticMethods.Tests
{
	public class WordStatisticsCalculatorTests
	{
		private ICalculatorHelpers _calculatorHelpers;

		private int _totalWords;
		private int _averageWordCountInSentence;
		private int _AverageWordLength;

		public WordStatisticsCalculatorTests()
		{
			_calculatorHelpers = Mock.Of<ICalculatorHelpers>();
			Mock.Get(_calculatorHelpers).Setup(e => e.CalculateTotalWords(It.IsAny<string[]>())).Returns(() => _totalWords);
			Mock.Get(_calculatorHelpers).Setup(e => e.CalculateAverageWordCountInSentence(It.IsAny<string[]>())).Returns(() => _averageWordCountInSentence);
			Mock.Get(_calculatorHelpers).Setup(e => e.CalculateAverageWordLength(It.IsAny<string[]>())).Returns(() => _AverageWordLength);
		}

		[Fact]
		public void CalculateStatistics_ForSingleSentence()
		{
			_totalWords = 4;
			_averageWordCountInSentence = 4;
			_AverageWordLength = 3;

			var text = "This is a  sentence";
			var calculator = new WordStatisticsCalculator(_calculatorHelpers);
			var result = calculator.CalculateStatistics(text);
			result.TotalWords.ShouldBe(_totalWords);
			result.AverageWordLength.ShouldBe(_AverageWordLength);
			result.AverageWordCountInSentence.ShouldBe(_averageWordCountInSentence);
		}

		[Fact]
		public void CalculateStatistics_ForMultiSentence()
		{
			_totalWords = 11;
			_averageWordCountInSentence = 4;
			_AverageWordLength = 5;

			var text = "This is a sentence. And this is another sentence with words";
			var calculator = new WordStatisticsCalculator(_calculatorHelpers);
			var result = calculator.CalculateStatistics(text);
			result.TotalWords.ShouldBe(_totalWords);
			result.AverageWordLength.ShouldBe(_AverageWordLength);
			result.AverageWordCountInSentence.ShouldBe(_averageWordCountInSentence);
		}
	}
}

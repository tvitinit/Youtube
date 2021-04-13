using Shouldly;
using System;
using Xunit;

namespace StaticMethods.Tests
{
	public class CalculatorHelpersTests
	{
		[Fact]
		public void CalculateTotalWords_NullyWordsReturnsZero()
		{
			var result = new CalculatorHelpers().CalculateTotalWords(null);
			result.ShouldBe(0);
		}

		[Fact]
		public void CalculateTotalWords_NoWordsReturnsZero()
		{
			var result = new CalculatorHelpers().CalculateTotalWords(Array.Empty<string>());
			result.ShouldBe(1);
		}

		[Fact]
		public void CalculateTotalWords_SomeWordsCalculates()
		{
			var result = new CalculatorHelpers().CalculateTotalWords(new[] { "bla", "bla1" });
			result.ShouldBe(3);
		}

		[Fact]
		public void CalculateAverageWordLength_NullWordsReturnsZero()
		{
			var result = new CalculatorHelpers().CalculateAverageWordLength(null);
			result.ShouldBe(0);
		}

		[Fact]
		public void CalculateAverageWordLength_NoWordsReturnsZero()
		{
			var result = new CalculatorHelpers().CalculateAverageWordLength(Array.Empty<string>());
			result.ShouldBe(0);
		}

		[Fact]
		public void CalculateAverageWordLength_SomeWordsCalculates()
		{
			var result = new CalculatorHelpers().CalculateAverageWordLength(new[] { "bl", "bla", "bla1" });
			result.ShouldBe(3);
		}

		[Fact]
		public void CalculateAverageWordCountInSentence_NullSentencesReturnsZero()
		{
			var result = new CalculatorHelpers().CalculateAverageWordCountInSentence(null);
			result.ShouldBe(0);
		}

		[Fact]
		public void CalculateAverageWordCountInSentence_NoSentencesReturnsZero()
		{
			var result = new CalculatorHelpers().CalculateAverageWordCountInSentence(Array.Empty<string>());
			result.ShouldBe(0);
		}

		[Fact]
		public void CalculateAverageWordCountInSentence_OneSentenceCalculates()
		{
			var result = new CalculatorHelpers().CalculateAverageWordCountInSentence(new[] { "bl bla bla1" });
			result.ShouldBe(3);
		}

		[Fact]
		public void CalculateAverageWordCountInSentence_MultipleSentencesCalculates()
		{
			var result = new CalculatorHelpers().CalculateAverageWordCountInSentence(new[] { "bl bla bla1", " bla bla bla bla bla" });
			result.ShouldBe(4);
		}
	}
}

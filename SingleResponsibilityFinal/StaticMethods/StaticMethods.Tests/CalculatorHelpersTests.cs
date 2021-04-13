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
			var result = CalculatorHelpers.CalculateTotalWords(null);
			result.ShouldBe(0);
		}

		[Fact]
		public void CalculateTotalWords_NoWordsReturnsZero()
		{
			var result = CalculatorHelpers.CalculateTotalWords(Array.Empty<string>());
			result.ShouldBe(0);
		}

		[Fact]
		public void CalculateTotalWords_SomeWordsCalculates()
		{
			var result = CalculatorHelpers.CalculateTotalWords(new[] { "bla", "bla1" });
			result.ShouldBe(2);
		}

		[Fact]
		public void CalculateAverageWordLength_NullWordsReturnsZero()
		{
			var result = CalculatorHelpers.CalculateAverageWordLength(null);
			result.ShouldBe(0);
		}

		[Fact]
		public void CalculateAverageWordLength_NoWordsReturnsZero()
		{
			var result = CalculatorHelpers.CalculateAverageWordLength(Array.Empty<string>());
			result.ShouldBe(0);
		}

		[Fact]
		public void CalculateAverageWordLength_SomeWordsCalculates()
		{
			var result = CalculatorHelpers.CalculateAverageWordLength(new[] { "bl", "bla", "bla1" });
			result.ShouldBe(3);
		}

		[Fact]
		public void CalculateAverageWordCountInSentence_NullSentencesReturnsZero()
		{
			var result = CalculatorHelpers.CalculateAverageWordCountInSentence(null);
			result.ShouldBe(0);
		}

		[Fact]
		public void CalculateAverageWordCountInSentence_NoSentencesReturnsZero()
		{
			var result = CalculatorHelpers.CalculateAverageWordCountInSentence(Array.Empty<string>());
			result.ShouldBe(0);
		}

		[Fact]
		public void CalculateAverageWordCountInSentence_OneSentenceCalculates()
		{
			var result = CalculatorHelpers.CalculateAverageWordCountInSentence(new[] { "bl bla bla1" });
			result.ShouldBe(3);
		}

		[Fact]
		public void CalculateAverageWordCountInSentence_MultipleSentencesCalculates()
		{
			var result = CalculatorHelpers.CalculateAverageWordCountInSentence(new[] { "bl bla bla1", " bla bla bla bla bla" });
			result.ShouldBe(4);
		}
	}
}

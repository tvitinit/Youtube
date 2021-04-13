using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SingleResponsibility.Test
{
	public class NumbersInSentenceDetectorTests
	{
		[Fact]
		public void DetectedNumbersInSentence_Detects25Correctly()
		{
			var detector = new NumbersInSentenceDetector();
			var sentence = new Sentence("dvacet pet");
			var result = detector.DetectedNumbersInSentence(sentence);
			result.ShouldNotBeNull();
			result.Count.ShouldBe(1);
			result[0].ShouldBe(25);
		}
	}
}

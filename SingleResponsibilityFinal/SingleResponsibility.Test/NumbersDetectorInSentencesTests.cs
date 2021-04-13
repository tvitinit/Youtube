using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SingleResponsibility.Test
{
	public class NumbersDetectorInSentencesTests
	{
		[Fact]
		public void Detect_ReturnsCorrectValuesForSingleSentence()
		{
			var sentenceHierarchy = new SentenceHierarchy(new List<List<Sentence>>
			{
				new List<Sentence>
				{
					new Sentence("dvacet jedna")
				}
			});
			var detector = new NumbersDetectorInSentences(new SentenceHashGenerator(), new NumbersInSentenceDetector());
			var detected = detector.Detect(sentenceHierarchy);
			detected.ShouldNotBeNull();
			detected.Count.ShouldBe(1);
			detected[0].ShouldNotBeNull();
			detected[0].Count.ShouldBe(1);
			detected[0][0].ShouldNotBeNull();
			detected[0][0].Numbers.Count.ShouldBe(1);
			detected[0][0].Numbers[0].ShouldBe(21);
		}

		[Fact]
		public void Detect_ReturnsCorrectValues()
		{
			var sentenceHierarchy = new SentenceHierarchy(new List<List<Sentence>>
			{
				new List<Sentence>
				{
					new Sentence("dvacet jedna"),
					new Sentence("dvacet pet"),
					new Sentence("jedenadvacet"),
					new Sentence("sestadvacet"),
				},
				new List<Sentence>
				{
					new Sentence("dvacet jedna"),
					new Sentence("bla bla bla"),
					new Sentence("bla dvacet bla"),
					new Sentence("dvacet jedna bla"),
					new Sentence("bla dvacet jedna"),
				}
			});
			var detector = new NumbersDetectorInSentences(new SentenceHashGenerator(), new NumbersInSentenceDetector());
			var detected = detector.Detect(sentenceHierarchy);
			detected.ShouldNotBeNull();
			detected.Count.ShouldBe(2);
			detected[0].ShouldNotBeNull();
			detected[0].Count.ShouldBe(4);
			detected[0][0].ShouldNotBeNull();
			detected[0][0].Numbers.Count.ShouldBe(1);
			detected[0][0].Numbers[0].ShouldBe(21);
			detected[0][1].ShouldNotBeNull();
			detected[0][1].Numbers.Count.ShouldBe(1);
			detected[0][1].Numbers[0].ShouldBe(25);
			detected[0][2].ShouldNotBeNull();
			detected[0][2].Numbers.Count.ShouldBe(1);
			detected[0][2].Numbers[0].ShouldBe(21);
			detected[0][3].ShouldNotBeNull();
			detected[0][3].Numbers.Count.ShouldBe(1);
			detected[0][3].Numbers[0].ShouldBe(26);
			detected[1].ShouldNotBeNull();
			detected[1].Count.ShouldBe(5);
			detected[1][0].ShouldNotBeNull();
			detected[1][0].Numbers.Count.ShouldBe(1);
			detected[1][0].Numbers[0].ShouldBe(21);
			detected[1][1].ShouldNotBeNull();
			detected[1][1].Numbers.Count.ShouldBe(0);
			detected[1][2].ShouldNotBeNull();
			detected[1][2].Numbers.Count.ShouldBe(1);
			detected[1][2].Numbers[0].ShouldBe(20);
			detected[1][3].ShouldNotBeNull();
			detected[1][3].Numbers.Count.ShouldBe(1);
			detected[1][3].Numbers[0].ShouldBe(21);
			detected[1][4].ShouldNotBeNull();
			detected[1][4].Numbers.Count.ShouldBe(1);
			detected[1][4].Numbers[0].ShouldBe(21);
		}
	}
}

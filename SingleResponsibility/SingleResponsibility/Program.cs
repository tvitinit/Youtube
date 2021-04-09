using System;
using System.Collections.Generic;

namespace SingleResponsibility
{
	class Program
	{
		static void Main(string[] args)
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
			var detector = new NumbersDetectorInSentences();
			var detected = detector.Detect(sentenceHierarchy);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
	public class WordStatistics
	{
		public int TotalWords { get; set; }

		public int AverageWordCountInSentence { get; set; }

		public int AverageWordLength { get; set; }

		public override string ToString()
		{
			return $@"Total words and sentences: {TotalWords}
Average Word Count in Sentence: {AverageWordCountInSentence}
Average Word Length: {AverageWordLength}";
		}
	}
}

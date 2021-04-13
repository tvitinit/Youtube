using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
	public class CzechNumbersInSentence
	{
		public CzechNumbersInSentence(Sentence sentence, List<int> numbers, int paragraphNumber, int sentenceNumber)
		{
			Sentence = sentence;
			Numbers = numbers;
			ParagraphNumber = paragraphNumber;
			SentenceNumber = sentenceNumber;
		}

		public Sentence Sentence { get; }

		public List<int> Numbers { get; }

		public int ParagraphNumber { get; }
		public int SentenceNumber { get; }
	}
}

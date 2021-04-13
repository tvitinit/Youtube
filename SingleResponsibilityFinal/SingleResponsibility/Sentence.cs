using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleResponsibility
{
	public class Sentence
	{
		public string OriginalSentence { get; }

		public List<string> Words { get; }

		public Sentence(string sentence)
		{
			OriginalSentence = sentence;
			Words = sentence.Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
		}
	}
}

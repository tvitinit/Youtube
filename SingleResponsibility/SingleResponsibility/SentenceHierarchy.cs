using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
	public class SentenceHierarchy
	{
		public List<List<Sentence>> Paragraphs { get; }

		public SentenceHierarchy(List<List<Sentence>> paragraphs)
		{
			Paragraphs = paragraphs;
		}
	}
}

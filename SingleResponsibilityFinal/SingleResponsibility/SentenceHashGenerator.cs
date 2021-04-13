using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
	public class SentenceHashGenerator : ISentenceHashGenerator
	{
		public int GenerateHash(Sentence sentence)
		{
			unchecked
			{
				int hash = 0;
				for (int i = 0; i < sentence.Words.Count; i++)
				{
					hash += sentence.Words[i].GetHashCode() * 2 * (i + 1);
				}
				return hash;
			}
		}

	}
}

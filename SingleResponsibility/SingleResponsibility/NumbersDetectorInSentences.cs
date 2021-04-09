using System;
using System.Collections.Generic;

namespace SingleResponsibility
{
	public class NumbersDetectorInSentences
	{
		public Dictionary<int, Dictionary<int, CzechNumbersInSentence>> Detect(SentenceHierarchy hierarchy)
		{
			if(hierarchy == null)
			{
				return null;
			}

			if(hierarchy.Paragraphs.Contains(null))
			{
				return null;
			}

			var numbersDetected = new Dictionary<int, Dictionary<int, CzechNumbersInSentence>>();
			var hashesForSentences = new Dictionary<int, CzechNumbersInSentence>();
			for (int paragraphId = 0; paragraphId < hierarchy.Paragraphs.Count; paragraphId++)
			{
				numbersDetected.Add(paragraphId, new Dictionary<int, CzechNumbersInSentence>());
				for (int sentenceId = 0; sentenceId < hierarchy.Paragraphs[paragraphId].Count; sentenceId++)
				{
					var sentence = hierarchy.Paragraphs[paragraphId][sentenceId];
					var sentenceHash = GenerateHash(sentence);
					hashesForSentences.TryGetValue(sentenceHash, out var existingNumbersInSentence);

					List<int> detectedNumbers;
					CzechNumbersInSentence numbersInSentence;
					if (existingNumbersInSentence == null)
					{
						detectedNumbers = DetectedNumbersInSentence(sentence);
						numbersInSentence = new CzechNumbersInSentence(sentence, detectedNumbers, paragraphId, sentenceId);
						hashesForSentences.Add(sentenceHash, numbersInSentence);
					}
					else
					{
						numbersInSentence = new CzechNumbersInSentence(sentence, existingNumbersInSentence.Numbers, paragraphId, sentenceId);
					}
					numbersDetected[paragraphId].Add(sentenceId, numbersInSentence);
				}
			}
			return numbersDetected;
		}

		private int GenerateHash(Sentence sentence)
		{
			unchecked
			{
				int hash = 0;
				for (int i = 0; i < sentence.Words.Count; i++)
				{
					hash += sentence.Words[i].GetHashCode() * 2 * i;
				}
				return hash;
			}
		}

		private List<int> DetectedNumbersInSentence(Sentence sentence)
		{
			var result = new List<int>();
			for (int i = 0; i < sentence.Words.Count; i++)
			{
				var word = sentence.Words[i];
				if (!word.Contains("dvacet"))
				{
					continue;
				}
				// it is 20

				var number = 20;
				int additionalNumber;
				if (word == "dvacet")
				{
					// next word might possibly number as well
					if (i == sentence.Words.Count - 1)
					{
						result.Add(number);
						break;
					}
					if (CheckNumber(sentence.Words[i + 1], false, out additionalNumber))
					{
						number += additionalNumber;
						result.Add(number);
						continue;
					}
					result.Add(number);
					continue;
				}

				// jeden a dvacet
				var firstNumber = word.Substring(0, word.IndexOf("dvacet") - 1);
				if (CheckNumber(firstNumber, true, out additionalNumber))
				{
					number += additionalNumber;
					result.Add(number);
					continue;
				}
				throw new Exception("Number seems to be crazy");
			}
			return result;
		}

		private bool CheckNumber(string firstNumber, bool mustMatch, out int additionalNumber)
		{
			switch (firstNumber)
			{
				case "jeden":
				case "jedna":
					additionalNumber = 1;
					return true;
				case "dva":
					additionalNumber = 2;
					return true;
				case "tri":
					additionalNumber = 3;
					return true;
				case "ctyri":
					additionalNumber = 4;
					return true;
				case "pat":
					additionalNumber = 5;
					return true;
				case "sest":
					additionalNumber = 6;
					return true;
				case "sedm":
					additionalNumber = 7;
					return true;
				case "osm":
					additionalNumber = 8;
					return true;
				case "devet":
					additionalNumber = 9;
					return true;
				default:
					if (mustMatch)
					{
						throw new Exception("Number seems to be crazy");
					}
					additionalNumber = 0;
					return true;
			}
		}
	}
}

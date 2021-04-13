using System;
using System.Collections.Generic;

namespace SingleResponsibility
{
	public class NumbersDetectorInSentences
	{
		private readonly ISentenceHashGenerator _sentenceHashGenerator;

		public NumbersDetectorInSentences(ISentenceHashGenerator sentenceHashGenerator, INumbersInSentenceDetector numbersInSentenceDetector)
		{
			_sentenceHashGenerator = sentenceHashGenerator;
			_numbersInSentenceDetector = numbersInSentenceDetector;
		}

		private readonly INumbersInSentenceDetector _numbersInSentenceDetector;

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
					var sentenceHash = _sentenceHashGenerator.GenerateHash(sentence);
					hashesForSentences.TryGetValue(sentenceHash, out var existingNumbersInSentence);

					List<int> detectedNumbers;
					CzechNumbersInSentence numbersInSentence;
					if (existingNumbersInSentence == null)
					{
						detectedNumbers = _numbersInSentenceDetector.DetectedNumbersInSentence(sentence);
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

	}
}

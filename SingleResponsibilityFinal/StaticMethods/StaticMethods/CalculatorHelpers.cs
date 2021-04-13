﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
	public class CalculatorHelpers
	{
		public static int CalculateTotalWords(string[] words)
		{
			if(words == null)
			{
				return 0;
			}

			return words.Length;
		}

		public static int CalculateAverageWordLength(string[] words)
		{
			if (words == null || words.Length == 0)
			{
				return 0;
			}

			var totalLength = 0;
			foreach (var word in words)
			{
				totalLength += word.Length;
			}
			return totalLength / words.Length;
		}

		public static int CalculateAverageWordCountInSentence(string[] sentences)
		{
			if (sentences == null || sentences.Length == 0)
			{
				return 0;
			}

			var totalWordsInSentences = 0;
			foreach (var sentence in sentences)
			{
				var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
				totalWordsInSentences += words.Length;
			}
			return totalWordsInSentences / sentences.Length;
		}
	}
}

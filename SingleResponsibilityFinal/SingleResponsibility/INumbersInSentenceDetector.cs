using System.Collections.Generic;

namespace SingleResponsibility
{
	public interface INumbersInSentenceDetector
	{
		List<int> DetectedNumbersInSentence(Sentence sentence);
	}
}
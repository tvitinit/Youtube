using System.Collections.Generic;

namespace SingleResponsibility
{
	public interface INumberDetectorInSentence
	{
		List<int> DetectedNumbersInSentence(Sentence sentence);
	}
}
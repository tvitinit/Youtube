namespace StaticMethods
{
	public interface ICalculatorHelpers
	{
		int CalculateAverageWordCountInSentence(string[] sentences);
		int CalculateAverageWordLength(string[] words);
		int CalculateTotalWords(string[] words);
	}
}
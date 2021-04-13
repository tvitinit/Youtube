namespace SingleResponsibility
{
	public interface ISentenceHashCodeGenerator
	{
		int GenerateHash(Sentence sentence);
	}
}
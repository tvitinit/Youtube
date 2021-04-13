using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SingleResponsibility.Test
{
	public class SentenceHashGeneratorTests
	{
		[Fact]
		public void GenerateHash_RetunsValue()
		{
			var generator = new SentenceHashGenerator();
			var sentence = new Sentence("bla");
			var result = generator.GenerateHash(sentence);
			result.ShouldBe("bla".GetHashCode() * 2);
		}
	}
}

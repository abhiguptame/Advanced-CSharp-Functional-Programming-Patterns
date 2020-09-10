using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;
namespace UnitTests
{
	[TestClass]
	public class PureFunctionsTests
	{
		[TestClass]
		public class APureFunction_Should
		{
			[TestMethod]
			public void ReturnSameResults_WhenSameInputs()
			{
				// Arrange
				var examples = new PureFunctions();
				long value = 5;
				long exponent = 3;

				// Act
				var result1 = examples.CalcExponent(value, exponent);
				var result2 = examples.CalcExponent(value, exponent);

				// Assert
				Assert.AreEqual((value ^ exponent), result1);
				Assert.AreEqual(result1, result2);
			}
		}
	}
}

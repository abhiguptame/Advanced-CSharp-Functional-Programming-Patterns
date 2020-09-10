using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;
using System;

namespace UnitTests
{
    public class ImpureFunctionsTests
    {
		[TestClass]
		public class CustomIntervalShould
		{
			[TestMethod]
			public void ReturnTheTimePlus5Interval()
			{
				// Arrange
				var examples = new ImpureFunctions();
				var testDateTime = new DateTime(year: 2021, month: 8, day: 21,
																	hour: 11, minute: 59, second: 12);
				var expectedResult = new DateTime(year: 2021, month: 8, day: 21,
																	hour: 12, minute: 00, second: 00);
				// Act
				var createdDateTime = examples.GetCurrentTimeRoundedUpToCustomMinuteIntervalRefactoredCodeToMakePureFunction(interval: 5, startTime: testDateTime);

				// Assert
				Assert.AreEqual(expectedResult, createdDateTime);
			}

			[TestMethod]
			public void ReturnTheTimePlus3Interval()
			{
				// Arrange
				var examples = new ImpureFunctions();
				var testDateTime = new DateTime(year: 2021, month: 8, day: 21,
																	hour: 9, minute: 13, second: 12);
				var expectedResult = new DateTime(year: 2021, month: 8, day: 21,
																	hour: 9, minute: 15, second: 00);

				// Act
				var createdDateTime = examples.GetCurrentTimeRoundedUpToCustomMinuteIntervalRefactoredCodeToMakePureFunction(interval: 3, startTime: testDateTime);

				// Assert
				Assert.AreEqual(expectedResult, createdDateTime);
			}
		}
	}
}

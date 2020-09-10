using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    public class ImmutableColorTests
    {
		[TestClass]
		public class ColorShould
		{

			[TestMethod]
			public void ReturnCorrectToString()
			{
				// Arrange
				var color1 = new ConsoleApp.Immutable.Color(0, 0, 0);
				var color2 = new ConsoleApp.Immutable.Color(127, 0, 0);

				// Act
				string formattedString1 = $"Red: {0}, Green: {0}, Blue: {0}";
				string formattedString2 = $"Red: {127}, Green: {0}, Blue: {0}";

				// Assert
				Assert.AreEqual(formattedString1, color1.ToString());
				Assert.AreEqual(formattedString2, color2.ToString());
			}

			[TestMethod]
			public void ReturnTrueWhenRGBAreZero()
			{
				// Arrange
				var color = new ConsoleApp.Immutable.Color(0, 0, 0);

				// Act
				var isBlack = color.IsBlack();

				// Assert
				Assert.IsTrue(isBlack);
			}

			[TestMethod]
			public void ReturnFalseWhenRGBNotZero()
			{

				var color1 = new ConsoleApp.Immutable.Color(1, 0, 0);
				var color2 = new ConsoleApp.Immutable.Color(0, 1, 0);
				var color3 = new ConsoleApp.Immutable.Color(0, 0, 1);


				Assert.IsFalse(color1.IsBlack());
				Assert.IsFalse(color2.IsBlack());
				Assert.IsFalse(color3.IsBlack());
			}
		}
	}
}

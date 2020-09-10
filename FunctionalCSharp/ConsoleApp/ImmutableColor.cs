using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Immutable;
using ConsoleApp.Immutable;

namespace ConsoleApp
{
    public class ImmutableColor
    {
		public void DoWork()
		{

			// instantiate the Immutable color class

			var myColor1 = new Immutable.Color(red: 127, green: 63, blue: 255);
			Console.WriteLine(myColor1.ToString());
			Console.WriteLine(myColor1.IsWhite);

			var myColor2 = new Immutable.Color(red: 191);
			Console.WriteLine(myColor2.ToString());
			Console.WriteLine(myColor2.IsBlack());
			

			Color color1 = new Color.Builder().Create(); // defaults
			Color color2 = new Color.Builder().Red(127).Create(); // red only
			Color color3 = new Color.Builder().Green(63).Alpha(255).Create(); // Green and Alpha

			var greenValue = color3.Green;
			Console.WriteLine(greenValue);

			//color2.Red = 0;

			Color lightenedColor = color3.Lighten(22);
			Console.WriteLine(lightenedColor.IsBlack());

			Console.ReadLine();
		}
	}
}

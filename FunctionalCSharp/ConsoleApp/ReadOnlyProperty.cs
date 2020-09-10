using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Immutable;

namespace ConsoleApp
{
    public class ReadOnlyProperty
    {
		public void DoWork()
		{

			// instantiate the Immutable color class

			var myColor1 = new Immutable.Color(red: 127, green: 63, blue: 255);
			Console.WriteLine(myColor1.ToString());

			var myColor2 = new Immutable.Color(red: 191);
			Console.WriteLine(myColor2.ToString());

			Console.ReadLine();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class FunctionsExamples
    {
		// how C# represents functions
		// Methods
		// Delegates
		// Lambda expressions

		// of these, Delegates and Lambda expressions 
		// are the most useful for functional programming
		public void DoWork()
		{
			UseLambda();

		}

		private void UseLambda()
		{
			// easy way to represent functions is with 
			// the Func<T> and Action<T> delegates

			// Use variable to store a function (as delegate type)
			// If your function is short, and doesn't need to be reused
			// a Lambda expression is useful
			Func<int, int> functionVar = x => (x * 10);

			int result = functionVar(6);
			Console.WriteLine(result.ToString());

			Func<int, int, bool> predicateVar = IsMultipleOf;


			bool isMultipleOfFive = predicateVar(25, 5);
			Console.WriteLine(isMultipleOfFive.ToString());

			bool isMultipleOfSeven = predicateVar(25, 7);
			Console.WriteLine(isMultipleOfSeven.ToString());

			Console.ReadLine();
		}

		// or create method when there is more code
		// or we need to call from other locations.

		public bool IsMultipleOf(int candidate, int multiplier)
		{
			return (candidate % multiplier) == 0;
		}
	}
}

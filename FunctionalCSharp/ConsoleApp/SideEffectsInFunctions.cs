using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class SideEffectsInFunctions
    {
		private int _counter = 0;


		// Avoid side effects in functions:
		// A side effect is a change of system state 
		// or observable interaction with the outside world
		// that occurs during the calculation of a result.

		// A function should not: 
		// 1. Mutate shared state
		// 2. Mutate its input arguments
		// 3. Throw exceptions
		// 4. Perform any I/O operation

		public void UpdateByTwo()
		{
			Console.WriteLine("Work with number:");
			Console.WriteLine(_counter);
			_counter += 2;
			Console.WriteLine(_counter);
		}
		public void UpdateByFive()
		{
			Console.WriteLine(_counter);
			_counter += 5;
			Console.WriteLine(_counter);
		}

		#region List as shared state

		public void WorkWithList()
		{
			Console.WriteLine("Work with List:");
			var countA = _numbers.Count;
			Console.WriteLine(countA);
			AddNumbersToList();
			var countB = _numbers.Count;
			Console.WriteLine(countB);
		}

		private List<int> _numbers = new List<int> { 1, 3, 5, 7 };

		public void AddNumbersToList()
		{
			TotalTheNumbers();
			_numbers.Add(2);
			_numbers.Add(4);
		}

		public int TotalTheNumbers()
		{
			int total = 0;
			foreach (int number in _numbers)
			{
				total += number;
			}

			Console.WriteLine("The sum of total number is:");
			Console.WriteLine(total);
			return total;
		}

		#endregion
	}
}

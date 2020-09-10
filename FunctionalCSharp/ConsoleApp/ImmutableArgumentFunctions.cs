using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace ConsoleApp
{
    public class ImmutableArgumentFunctions
    {

		#region Don't mutate input arguments
		public void DoWork()
		{

			// Modify to work with .NET Immutable collections

			ImmutableList<int> numbersList;
			numbersList = ImmutableList<int>.Empty;
			numbersList = ImmutableList.Create<int>(1, 3, 5, 7);

			TotalTheNumbers(numbersList);
			AddNumbersToList(numbersList);
			TotalTheNumbers(numbersList);			
		}

		public ImmutableList<int> AddNumbersToList(ImmutableList<int> inputList)
		{
			// Pure functions should treat inputs 
			// as immutable
			// Immutable types are a core concept for FP
			return inputList.Add(2);
			//inputList.Add(4);
		}
		public int TotalTheNumbers(ImmutableList<int> inputList)
		{
			int total = 0;
			foreach (int number in inputList)
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

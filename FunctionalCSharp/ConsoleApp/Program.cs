using System;
using System.Threading;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// Impure Functions Start

			//Timer t = new Timer(TimerCallback, null, 0, 1000);
			//Console.ReadLine();
			// Impure Functions End

			// Side Effects in Functions Start

			//var examples = new SideEffectsInFunctions();
			//examples.UpdateByTwo();
			//examples.UpdateByFive();

			//examples.WorkWithList();
			//examples.TotalTheNumbers();

			//Console.ReadLine();
			// Side Effects in Functions End

			// 
			var examples = new ImmutableArgumentFunctions();
			examples.DoWork();

		}


		#region Impure Functions

		private static void TimerCallback(Object o)
		{
			var examples = new ImpureFunctions();
			Console.Clear();
			Console.WriteLine(DateTime.Now);
			// Impure Function
			//var result = examples.GetCurrentTimeRoundedUpToCustomMinuteInterval(4);

			// Refactored Impure Function
			var result = examples.GetCurrentTimeRoundedUpToCustomMinuteIntervalRefactoredCodeToMakePureFunction(4, DateTime.Now);

			Console.WriteLine(result);
		}

		#endregion

	}
}

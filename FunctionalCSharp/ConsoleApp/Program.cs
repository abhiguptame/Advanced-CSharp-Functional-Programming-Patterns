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

			// Immutable Argument Function Start 
			//var examples = new ImmutableArgumentFunctions();
			//examples.DoWork();
			// Immutable Argument Function End

			// Immutable Color  Start 
			//var examples = new ImmutableColor();
			//examples.DoWork();
			// Immutable Color End 

			// Side Effects and I/O 
			//var examples = new RobotFile();
			//examples.DoWork();

			// Side Effects and I/O End

			// Expression Refactor Start			
			//var examples = new ExpressionRefactor();
			//examples.DoWork();

			// Expression Refactor End

			// Functions Examples Start
			//var examples = new FunctionsExamples();
			//examples.DoWork();

			// Functions Examples End

			// Higher Order Functions Start
			var examples = new HigherOrderFunctions();
			examples.DoWork();

			// Higher Order Functions End
			

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

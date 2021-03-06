﻿using System;
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
			//var examples = new HigherOrderFunctions();
			//examples.DoWork();

			// Higher Order Functions End

			// Composition Patterns Start
			//var examples = new CompositionPatterns();
			//examples.DoWorkWithFunc();

			// Composition Patterns End

			// Pipeline Composition Pattern Start

			//var examples = new PipelineCompositionPatterns();
			//examples.DoWorkWithPipeline();

			// Pipeline Composition Pattern End


			// Pipeline Composition Pattern Start

			//var examples = new PipelineUsingGenericCompositionPatterns();
			//examples.DoWorkWithPipeine();

			// Pipeline Composition Pattern End


			// Pipeline Composition Pattern Start

			//var examples = new PipelineUsingIEnummerableCompositionPatterns();
			//examples.UseEnumerablePipeline();

			// Pipeline Using IEnummerbale Composition Pattern End		

			// Map Using LINQ Select Start
			//var examples = new MapUsingLINQSelect();
			//examples.SelectWithNoTransform();
			//examples.SelectWithNumberTransform();
			//examples.SelectProjectToAnotherType();

			// Map Using LINQ Select Start

			// Filter With LINQ Where Start
			//var examples = new FilterUsingLINQWhere();
			//examples.FilterSimple();
			//examples.FilterForPrimeNumbers();
			//Filter With LINQ Where End

			// Flatten Using LINQ SelectMany Start 
			//var examples = new FlattenUsingLINQSelectMany();
			//examples.JoinExample();

			// Flatten Using LINQ SelectMany End

			// Aggregate Using LINQ Start
			var examples = new AggregateUsingLINQ();
			examples.AggregateExample();

			// Aggregate Using LINQ End
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

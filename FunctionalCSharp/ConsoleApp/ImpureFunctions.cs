using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class ImpureFunctions
    {
		// this is an impure function because it returns different
		// values given the same inputs.

		// also this code is not easily testable
		public DateTime GetCurrentTimeRoundedUpToCustomMinuteInterval(int interval)
		{
			var currentTime = DateTime.Now;
			var minutesSpan = TimeSpan.FromMinutes(interval).Ticks;

			if (currentTime.Ticks % minutesSpan == 0)
			{
				return currentTime;
			}
			else
			{
				return new DateTime((currentTime.Ticks / minutesSpan + 1) * minutesSpan);
			}

		}



		public DateTime GetCurrentTimeRoundedUpToCustomMinuteIntervalRefactoredCodeToMakePureFunction(int interval, DateTime startTime)
		{
			//var currentTime = DateTime.Now;
			var minutesSpan = TimeSpan.FromMinutes(interval).Ticks;

			if (startTime.Ticks % minutesSpan == 0)
			{
				return startTime;
			}
			else
			{
				return new DateTime((startTime.Ticks / minutesSpan + 1) * minutesSpan);
			}

		}
	}
}

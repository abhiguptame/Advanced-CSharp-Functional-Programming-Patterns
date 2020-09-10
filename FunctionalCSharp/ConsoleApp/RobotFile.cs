using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp
{
    public class RobotFile
    {
		// I/O is a side effect
		// Create separate functions for all I/O work

		// example. OpenFile, UpdateFile
		// Use pure function to perform computations on the file contents.

		private const string RobotFileName = "RobotNames.xml";

		public void DoWork()
		{
			var robotNames = GetRobots();
			robotNames.ForEach(x => {
				Console.WriteLine(x.RobotName);
			});
			Console.ReadLine();
		}

		public ImmutableList<Robot> GetRobots()
		{
			var xmlDoc = XDocument.Load(RobotFileName);
			var robots = xmlDoc.Root.Elements("Robot")
								.Select(x => new Robot
								{
									RobotName = x.Element("RobotName").Value,
									TeamName = x.Element("TeamName").Value,
									Weight = (int)x.Element("Weight")
								}).ToArray();
			return ImmutableList.Create(robots);
		}

		public string SaveToFile()
		{
			return null;
		}
	}
}

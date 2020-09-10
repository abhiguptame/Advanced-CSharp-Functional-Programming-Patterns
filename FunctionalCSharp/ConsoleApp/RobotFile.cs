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
			var robots = GetRobots();
			Console.WriteLine("RobotName | TeamName | Strength | Speed | Weight");
			robots.ForEach(x => {
				Console.WriteLine(x.RobotName + " | " + x.TeamName + " | " + x.Strength.ToString() + " | " + x.Speed.ToString() + " | " + x.Weight.ToString());
			});

			Console.WriteLine("Total Weight (All): " + GetTotalWeight(robots).ToString());

			var blueRobots = ImmutableList.Create(robots.Where(x => x.TeamName == "Blue").ToArray());
			int blueTeamTotal = GetTotalWeight(blueRobots);
			Console.WriteLine("Total Weight (Blue Team): " + blueTeamTotal.ToString());

			Console.ReadLine();
		}

		public ImmutableList<Robot> GetRobots()
		{
			var ran = new Random();
			var xmlDoc = XDocument.Load(RobotFileName);
			var robots = xmlDoc.Root.Elements("Robot")
								.Select(x => new Robot
								{
									RobotName = x.Element("RobotName").Value,
									TeamName = x.Element("TeamName").Value,
									Weight = (int)x.Element("Weight"),
									Speed = ran.Next(1, 18),
									Strength = ran.Next(1, 18),
									Endurance = ran.Next(1, 18)
								}).ToArray();
			return ImmutableList.Create(robots);
		}

		public string SaveToFile()
		{
			return null;
		}

		public int GetTotalWeight(ImmutableList<Robot> robots)
		{
			int total = 0;
			foreach (Robot robot in robots)
			{
				total += robot.Weight;
			}
			return total;
		}
	}
}

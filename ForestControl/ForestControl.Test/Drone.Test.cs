using System;
using System.Linq;
using ForestControl.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForestControl.Test
{
	[TestClass]
	public class DroneTestCases
	{
		[DataRow("3 3 N", "MMRMMRMRRM", false)]
		[DataRow("3 3 N", "", false)]
		[DataRow("3 3 e", "R", false)]
		[DataRow("0 0 s", "R M L", false)]
		[DataRow("0 0 s", "R  ML", false)]
		[DataRow("0 0 s", " R M L ", false)]
		[DataRow("0", "R M L", true)]
		[DataRow("0 0 s", "R M P", true)]
		[DataRow("0 0 s", "asd", true)]
		[DataTestMethod]
		public void Drone_Constructor(string start, string moves, bool shouldFail)
		{
			if (shouldFail)
            {
				Assert.ThrowsException<Exception>(() => new Drone(new Map("3 3"), start, moves));
            }
			else
            {
				var drone = new Drone(new Map("3 3"), start, moves);
				Assert.IsTrue(drone.Start != null && drone.Start.X >= 0 && drone.Start.Y >= 0 && drone.Start.Orientation > 0);
				Assert.IsTrue(drone.Movements.All(moves.Contains));
			}
		}

		[DataRow("5 5", "3 3 E", "L", "3 3 N")]
		[DataRow("5 5", "3 3 E", "R", "3 3 S")]
		[DataRow("5 5", "3 3 E", "M", "4 3 E")]
		[DataRow("5 5", "3 3 N", "LM", "2 3 O")]
		[DataRow("5 5", "3 3 E", "MMRMMRMRRM", "5 1 E")]
		[DataRow("5 5", "1 2 N", "LMLMLMLMMLMLMLMLMM", "1 4 N")]
		[DataTestMethod]
		public void Drone_Move(string map, string start, string moves, string result)
        {
			// Init
			var drone = new Drone(new Map(map), start, moves);
			var expectedPoint = new Point(result);
			
			// act
			var endPoint = drone.Move();
			
			// Assert
			Assert.AreEqual(expectedPoint.X, endPoint.X);
			Assert.AreEqual(expectedPoint.Y, endPoint.Y);
			Assert.AreEqual(expectedPoint.Orientation, endPoint.Orientation);
		}
	}
}

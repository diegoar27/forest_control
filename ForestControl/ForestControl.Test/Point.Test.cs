using System;
using System.Collections.Generic;
using System.Text;
using ForestControl.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForestControl.Test
{
	[TestClass]
	public class PointTestCases
	{
		[DataRow("3 3 N", false)]
		[DataRow("5 1 E", false)]
		[DataRow("5  11 E", false)]
		[DataRow(" 5 11 s", false)]
		[DataRow("5 11  o", false)]
		[DataRow("5 11 o ", false)]
		[DataRow("E 11 5", true)]
		[DataRow("6 S 5", true)]
		[DataRow("6 6 W", true)]
		[DataRow("6 E S", true)]
		[DataRow("6 7 5E", true)]
		[DataRow("6 S", true)]
		[DataRow("6", true)]
		[DataRow("E", true)]
		[DataRow("", true)]
		[DataTestMethod]
		public void Point_Constructor(string line, bool shouldFail)
		{
			if (shouldFail)
            {
				Assert.ThrowsException<Exception>(() => new Point(line));
            }
			else
            {
				var point = new Point(line);
				Assert.IsTrue(point.X > 0 && point.Y > 0);
				Assert.IsTrue(point.Orientation > 0);
			}
		}
	}
}

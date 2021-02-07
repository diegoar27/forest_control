using System;
using ForestControl.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForestControl.Test
{
    [TestClass]
	public class MapTest
	{
		[DataRow("5 5", false)]
		[DataRow("5 55", false)]
		[DataRow("5  55", false)]
		[DataRow("5 55 ", false)]
		[DataRow(" 5 55", false)]
		[DataRow("555", true)]
		[DataRow("a 5", true)]
		[DataRow("B", true)]
		[DataRow("", true)]
		[DataRow(" ", true)]
		[DataTestMethod]
		public void Map_Constructor(string line, bool shouldFail)
		{
			if (shouldFail)
            {
				Assert.ThrowsException<Exception>(() => new Map(line));
            }
			else
            {
				var map = new Map(line);
				Assert.IsTrue(map.Height > 0);
				Assert.IsTrue(map.Height > 0);
			}
		}
	}
}

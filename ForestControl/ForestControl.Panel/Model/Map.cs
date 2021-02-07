using System;
using System.Linq;
using ForestControl.Panel.Extensions;

namespace ForestControl.Model
{
	public class Map
	{
		public int Height { get; set; }
		public int Width { get; set; }

		public Map(string line)
		{
			try
			{
				var items = line.Split(' ').RemoveWhiteSpaces();

				this.Height = int.Parse(items.ElementAtOrDefault(0));
				this.Width = int.Parse(items.ElementAtOrDefault(1));
			}
			catch (Exception ex)
			{
				throw new Exception("Line 1 is wrong");
			}
		}
	}
}

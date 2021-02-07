using System;
using System.Linq;
using ForestControl.Panel.Extensions;

namespace ForestControl.Model
{
	public class Point
	{
		public int X { get; set; }
		public int Y { get; set; }
		public Orientation Orientation { get; set; }
		public Point(string line)
		{
			try
			{
				var items = line.Split(' ').RemoveWhiteSpaces();

				this.X = int.Parse(items.ElementAtOrDefault(0));
				this.Y = int.Parse(items.ElementAtOrDefault(1));
				this.Orientation = items.ElementAtOrDefault(2).ParseFromString();
			}
			catch (Exception ex)
			{
				throw new Exception($"Something went wrong with {line}");
			}
		}

		public Point(int x, int y, Orientation orientation)
        {
			this.X = x;
			this.Y = y;
			this.Orientation = orientation;
        }

        public override string ToString()
        {
            return $"{X} {Y} {this.Orientation.GetDescription()}";
        }
    }
}

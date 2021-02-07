using System;
using System.Linq;

namespace ForestControl.Model
{
	public class Drone
	{
        private readonly char[] AvailableMovemets = new[] { 'M', 'L', 'R' };
		public Map Map { get; set; }
        public Point Start { get; set; }
		public char[] Movements { get; set; }
		public Drone(Map map, string startPoint, string movements)
		{
			this.Map = map;
			this.Start = new Point(startPoint);

			var moves = movements.Where(x => char.IsLetter(x)).ToArray();
			if (moves.All(AvailableMovemets.Contains))
			{
				this.Movements = moves;
			}
			else
			{
				throw new System.Exception($"Something is wrong {movements}");
			}
		}
		public Point Move()
		{
			var point = this.Start;
            foreach (var move in Movements)
            {
				point = Next(point, move);
				if (point is null) break;
            }

            return point;
		}
		private Point Next(Point actual, char order)
        {
			Point point;
			switch (order)
			{
				case 'L':
				case 'R':
					point = new Point(actual.X, actual.Y, Rotate(actual.Orientation, order));
					break;
				case 'M' when actual.Orientation == Orientation.North:
					point = new Point(actual.X, actual.Y+1, actual.Orientation);
					break;
				case 'M' when actual.Orientation == Orientation.East:
					point = new Point(actual.X+1, actual.Y, actual.Orientation);
					break;
				case 'M' when actual.Orientation == Orientation.South:
					point = new Point(actual.X, actual.Y-1, actual.Orientation);
					break;
				case 'M' when actual.Orientation == Orientation.West:
					point = new Point(actual.X-1, actual.Y, actual.Orientation);
					break;
				default:
					throw new Exception("Unexpected error");
			}

			return IsValid(point) ? point : null;
		}

		private bool IsValid(Point point) => point.X >= 0 && point.X <= Map.Width && point.Y >= 0 && point.Y <= Map.Width; 

		private Orientation Rotate(Orientation actual, char order)
        {
            return order switch
            {
                'R' => actual == Orientation.West ? Orientation.North : actual + 1,
                'L' => actual == Orientation.North ? Orientation.West : actual - 1,
                _ => throw new Exception("Unexpected error"),
            };
        }
	}
}

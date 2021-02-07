using System.ComponentModel;

namespace ForestControl.Model
{
	public enum Orientation
	{
		[Description("N")]
		North = 1,
		[Description("E")]
		East = 2,
		[Description("S")]
		South = 3,
		[Description("O")]
		West = 4
	}
}

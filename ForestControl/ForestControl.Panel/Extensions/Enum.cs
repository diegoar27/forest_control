using System;
using System.ComponentModel;
using ForestControl.Model;

namespace ForestControl.Panel.Extensions
{
	public static class EnumExtensions
	{
		public static Orientation ParseFromString(this string value)
		{
			switch (value.ToUpper())
			{
				case "N": return Orientation.North;
				case "E": return Orientation.East;
				case "S": return Orientation.South;
				case "O": return Orientation.West;
				default:
					throw new Exception($"Orientation wrong {value}");
			}
		}

		public static string GetDescription(this Orientation value)
        {
            var description = value.ToString();
            var fieldInfo = value.GetType().GetField(value.ToString());

            if (fieldInfo != null)
            {
                var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs != null && attrs.Length > 0)
                {
                    description = ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return description;
        }
	}
}

using System.Collections.Generic;
using System.Linq;

namespace ForestControl.Panel.Extensions
{
    public static class StringExtensions
    {
        public static IEnumerable<string> RemoveWhiteSpaces(this IEnumerable<string> value)
            => value.Where(x => !string.IsNullOrEmpty(x) || !string.IsNullOrWhiteSpace(x));
    }
}

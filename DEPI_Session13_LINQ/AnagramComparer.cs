using System;
using System.Collections.Generic;
using System.Text;

namespace DEPI_Session13_LINQ
{
    class AnagramComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            if (x == null || y == null)
                return false;

            x = x.Trim();
            y = y.Trim();

            return x.OrderBy(c => c).SequenceEqual(y.OrderBy(c => c));
        }

        public int GetHashCode(string obj)
        {
            return string.Concat(
                obj.Trim()
                    .OrderBy(c => c)
            ).GetHashCode();
        }
    }
}

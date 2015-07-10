using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyABC.Common.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool SafeSequenceEqual<T>(this IEnumerable<T> enum1, IEnumerable<T> enum2)
        {
            bool isEqual = enum1 == enum2;
            if (!isEqual && enum1 != null && enum2 != null)
            {
                isEqual = enum1.SequenceEqual(enum2);
            }
            return isEqual;
        }
    }
}

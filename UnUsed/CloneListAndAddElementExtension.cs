using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo.UnUsed
{
    internal static class ListExtension
    {
        internal static List<T> CloneAndAdd<T>(this List<T> source, T a)
        {
            List<T> tempList = new List<T>(source.Count + 1);

            tempList = source.GetRange(0, source.Count);
            tempList.Add(a);
            return tempList;
        }
        internal static List<T> Clone<T>(this List<T> source)
        {
            return source.GetRange(0, source.Count);
        }
    }
}

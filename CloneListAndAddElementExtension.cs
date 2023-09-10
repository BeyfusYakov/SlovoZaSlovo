using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal static class ListExtension
    {
        public static List<T> CLoneAndAdd<T>(this List<T> source, T a)
        {
            List<T> tempList = new List<T>();
            
            tempList = source.GetRange(0, source.Count);
            tempList.Add(a);
            return tempList;
        }

        public static List<T> CLone<T>(this List<T> source)
        {
            return source.GetRange(0, source.Count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public static class FilteringObject
    {
       //public delegate bool criteriaDelegate(int number); 
       public static int[] Filter(int[] values, Func<int, bool> criteria)
        {
            List<int> filteredResult = new List<int>();
            foreach (var item in values)
            {
                if (criteria(item))
                {
                    filteredResult.Add(item);
                }
            }

            return filteredResult.ToArray();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class ITwoTest
    {
        // Assumptions:
        // 4 duplicate numbers consists of 2 sets of 2, or 4 x dublicate numbers; n-1 duplicates to be removed
        // Return string length < original length
        // number of elements > 10 will be removed from the end


        private int[] _range = new int[10];

        public ITwoTest(int[] range)
        {
            
            if (range.Length > 10)
            {
                range = range.Take(10).ToArray();
            }

            // Check that all values are less than 100

            _range = range.Where(x => x <= 100).Select(x=>x).ToArray();
        }

        public IEnumerable<int> GetOrderedSet()
        {
            var distinct = _range.Select(x => x).Distinct().ToArray();
            Array.Sort(distinct);
            return distinct;
        }
    }
}

using GenericSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.ArraysHashing
{
    public class MoveZerosEndArray : ISolution<List<int>, List<int>>
    {
        /*
         * Time Complexity: O(n). 
         * Auxiliary Space: O(1).
         */
        public string LeetCodeUrl()
        {
            return "https://leetcode.com/problems/move-zeroes/";
        }

        public List<int> Solve(List<int> t)
        {
            int count = 0;
            for (int i = 0; i < t.Count; i++)
                if (t[i] != 0)
                    t[count++] = t[i];
            for (int i = count; i < t.Count; i++)
                t[i] = 0;
            
            return t;
        }
    }
}

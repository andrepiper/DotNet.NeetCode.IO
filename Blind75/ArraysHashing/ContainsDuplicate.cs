using GenericSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.ArraysHashing
{
    public class ContainsDuplicate : ISolution<int[], bool>
    {
        public ContainsDuplicate() { }

        public string LeetCodeUrl()
        {
            return "https://leetcode.com/problems/contains-duplicate/";
        }

        public bool Solve(int[] nums)
        {
            List<int> numbers = new List<int>();
            foreach (int num in nums) {
                if (numbers.Contains(num)) return true;
                else
                    numbers.Add(num);
            }
            return false;
        } 
    }
}

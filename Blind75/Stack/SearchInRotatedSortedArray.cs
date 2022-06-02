using GenericSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Stack
{
    public class SearchInRotatedSortedArray : ISolution<List<int>,int>
    {
        private readonly int _taget;
        public SearchInRotatedSortedArray(int target)
        {
            _taget = target;
        }
        public string LeetCodeUrl()
        {
            return "https://leetcode.com/problems/search-in-rotated-sorted-array/";
        }

        public int Solve(List<int> list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left <= right)
            {  //[10]
                int mid = (left + right) / 2;
                if (list[mid] == _taget)
                {
                    return mid;
                }

                // Search in left portion
                if (list[left] <= list[mid])
                {
                    if (_taget > list[mid] || _taget < list[left])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                // Search in right portion
                else
                {
                    if (_taget > list[right] || _taget < list[mid])
                    {
                        // go to left
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }
            return -1;
        }
    }
}
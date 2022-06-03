using Blind75.Common;
using GenericSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.LinkedList
{
    public class MaxDepthOfTree : ISolution<TreeNode, int>
    {
        public string LeetCodeUrl()
        {
            return "https://leetcode.com/problems/maximum-depth-of-binary-tree/";
        }

        public int Solve(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else if (root.left == null && root.right == null)
            {
                return 1;
            }
            else
            {
                return 1 + Math.Max(this.Solve(root.left), this.Solve(root.right));
            }
        }
    }
}

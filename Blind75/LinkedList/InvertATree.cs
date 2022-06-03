using Blind75.Common;
using GenericSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.LinkedList
{
    public class InvertATree : ISolution<TreeNode, TreeNode>
    {
        public string LeetCodeUrl()
        {
            return "https://leetcode.com/problems/invert-binary-tree/";
        }

        public TreeNode Solve(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode left = this.Solve(root.left);
            TreeNode right = this.Solve(root.right);
            root.left = right;
            root.right = left;
            return root;
        }
    }
}

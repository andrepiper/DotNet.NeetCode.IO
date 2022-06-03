using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Common
{
    /**
     * Ref : https://stackoverflow.com/questions/828398/how-to-create-a-binary-tree
     */
    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int[] values) : this(values, 0) { }

        TreeNode(int[] values, int index)
        {
            Load(this, values, index);
        }

        void Load(TreeNode tree, int[] values, int index)
        {
            this.value = values[index];
            if (index * 2 + 1 < values.Length)
            {
                this.left = new TreeNode(values, index * 2 + 1);
            }
            if (index * 2 + 2 < values.Length)
            {
                this.right = new TreeNode(values, index * 2 + 2);
            }
        }
    }
}

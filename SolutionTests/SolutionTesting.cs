using Blind75.ArraysHashing;
using Blind75.Common;
using Blind75.LinkedList;
using Blind75.Stack;

namespace SolutionTests
{
    public class SolutionTesting
    {
        public SolutionTesting(){}

        [Fact]
        public void ContainsDuplicate()
        {
            var containsDuplicate = new ContainsDuplicate();
            var response = containsDuplicate.Solve(new List<int>() { 1, 3, 5, 6, 1, 7, 8, 9, 10 }.ToArray());
            Assert.True(response);
        }

        [Fact]
        public void SearchInRotatedSortedArray()
        {
            int target = 0;
            var searchInRotatedSortedArray= new SearchInRotatedSortedArray(target);
            var response = searchInRotatedSortedArray.Solve(new List<int>() { 4, 5, 6, 7, 0, 1, 2 });
            Assert.True(response != -1);
        }
        [Fact]
        public void MoveZerosEndArray()
        {
            var moveZerosEndArray = new MoveZerosEndArray();
            var response = moveZerosEndArray.Solve(new List<int>() {0, 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 });
            Assert.True(response[response.Count - 1].Equals(0));
        }
        [Fact]
        public void InvertATree()
        {
            var invertATree = new InvertATree();
            var treeNode = new TreeNode(new List<int>() { 1, 2, 3, 4, 5, 10, 13, 16, 22 }.ToArray());
            var response = invertATree.Solve(treeNode);
            Assert.True(response!=null);
        }
        [Fact]
        public void MaxDepthOfTree()
        {
            var maxDepthOfTree = new MaxDepthOfTree();
            var treeNode = new TreeNode(new List<int>() { 1, 2, 3, 4, 5, 10, 13, 16, 22 }.ToArray());
            var response = maxDepthOfTree.Solve(treeNode);
            Assert.True(response >= 0);
        }
        [Fact]
        public void ValidParentheses()
        {
            var validParentheses = new ValidParentheses();
            var response = validParentheses.Solve("()[]{}{");
            Assert.True(response.Equals(false));
        }
    }
}
using Blind75.ArraysHashing;
using Blind75.Stack;

namespace SolutionTests
{
    public class SolutionTesting
    {
        public SolutionTesting()
        {
        }

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
    }
}
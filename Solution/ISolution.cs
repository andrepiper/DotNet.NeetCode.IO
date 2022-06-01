using System;

namespace GenericSolution
{
    public interface ISolution<T, K>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        K Solve(T t);
        string LeetCodeUrl();
    }
}

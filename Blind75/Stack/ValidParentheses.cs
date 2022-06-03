using GenericSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75.Stack
{
    public class ValidParentheses : ISolution<string, bool>
    {
        public string LeetCodeUrl()
        {
            return "https://leetcode.com/problems/valid-parentheses/";
        }

        public bool Solve(string s)
        {
            var stack = new Stack<char>();
            Dictionary<char, char> closeToOpen = new Dictionary<char, char>();
            closeToOpen.Add(')', '(');
            closeToOpen.Add(']', '[');
            closeToOpen.Add('}', '{');

            foreach (char c in s)
            {
                if (closeToOpen.ContainsKey(c))
                {
                    if (!stack.Any() && stack.Peek() == closeToOpen[c])
                    {
                        stack.Pop();
                    }
                    else return false;
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Any();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionTests
{
    public class Utils
    {
        public static void Print(string str)
        {
            Console.WriteLine($"Response :  {str}");
        }
        public static void Print(bool b)
        {
            Console.WriteLine($"Response :  {b}");
        }
        public static void Print(int[] arr)
        {
            Console.WriteLine($"Response :  {string.Join(", ", arr)}");
        }
    }
}

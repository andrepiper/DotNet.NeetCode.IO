using Blind75.ArraysHashing;
using GenericSolution;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddTransient<ISolution<int[], bool>, ContainsDuplicate>()
                .BuildServiceProvider();

            Console.WriteLine($"-----------------------Starting {typeof(ConsoleApp.Program)} application-----------------------");


            var containsDuplicate = serviceProvider.GetService<ISolution<int[], bool>>();

            containsDuplicate = serviceProvider.GetService<ContainsDuplicate>();

            var response = containsDuplicate.Solve(new List<int>() {1,3,5,6,1,7,8,9,10 }.ToArray());

            Console.WriteLine($"Response :  {response}");
            Console.WriteLine($"Url :  {containsDuplicate.LeetCodeUrl()}");

            Console.WriteLine($"-----------------------Ended {typeof(ConsoleApp.Program)} application-----------------------");

        }
    }
}

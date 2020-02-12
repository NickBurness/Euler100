using Euler100Classes;
using System;

namespace Euler100Console
{
    class Program
    {
        static void Main(string[] args)
        {
			var test = new MultiplesOf3And5();
			var result = test.Challenge1();

			Console.WriteLine($"result is {result}");
		}
    }
}

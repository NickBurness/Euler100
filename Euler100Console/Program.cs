using Euler100Classes;
using System;

namespace Euler100Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Running");
            // Challenge 1 
            // var test = new MultiplesOf3And5();
            // var result = test.Challenge1();
            // Console.WriteLine($"result is {result}");

            // Challenge 2 
            // var test1 = new EvenFibonacciNumbers();
            // var result1 = test1.Challenge2();
            // Console.WriteLine($"The total value of even fibonacci numbers below 4 million is {result1}");

            // Challenge 3 
            //var test2 = new LargestPrimeFactor();
            //var result2 = test2.Challenge3(600851475143);
            //Console.WriteLine($"The largest prime factor of the 600851475143 is {result2}");

            // Challenge 4
            var test3 = new LargestPalindromeProduct();
            var result3 = test3.Challenge4();
            Console.WriteLine($"The largest palindrome made from the product of two 3-digit numbers is {result3}");
		}
    }
}

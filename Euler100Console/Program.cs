using Euler100Classes;
using System;

namespace Euler100Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Program Running");
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
            // var test3 = new LargestPalindromeProduct();
            // var result3 = test3.Challenge4();
            // Console.WriteLine($"The largest palindrome made from the product of two 3-digit numbers is {result3}");

            // Challenge 5
            // var test4 = new SmallestMultiple();
            // var result4 = test4.Challenge5();
            // Console.WriteLine($"The smallest number that can be evenly divided by all numbers from 1 upto 20 is {result4}");

            // Challenge 6
            // var test5 = new SumSquareDifference();
            // var result5 = test5.Challenge6();
            // Console.WriteLine($"The difference between the sum of the squares for the first 100 numbers and their squared value is {result5}");

            // Challenge 7
            // var test6 = new Prime10001();
            // int result6 = test6.Challenge7();
            // Console.WriteLine($"The 10001st prime number is {result6}");

            // Challenge 8
            var test7 = new LargestProductInASeries();
            long result7 = test7.Challenge8();
            Console.WriteLine($"The Product of the largest 13 adjacent numbers in the 1000-digit number provided in the challenge is {result7}");


		}
    }
}

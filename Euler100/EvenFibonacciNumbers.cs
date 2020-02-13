using System;
using System.Collections.Generic;
using System.Text;

namespace Euler100Classes
{
	public class EvenFibonacciNumbers
	{
		public int Challenge2()
		{
			var fibonacciNumbers = new List<int> { 1, 1, 2, 3, 5 };
			int totalEvenFibonacci = 0;

			while (fibonacciNumbers.Count < 34)
			{
				var previousOne = fibonacciNumbers[fibonacciNumbers.Count - 1];
				var previousTwo = fibonacciNumbers[fibonacciNumbers.Count - 2];
				fibonacciNumbers.Add(previousOne + previousTwo);
			}

			foreach (int number in fibonacciNumbers)
			{
				Console.WriteLine(number);
				if (number % 2 == 0)
				{
					totalEvenFibonacci += number;
					Console.WriteLine($"even fibonacci total so far is {totalEvenFibonacci}");
				}
			}
			return totalEvenFibonacci;
		}
	}
}

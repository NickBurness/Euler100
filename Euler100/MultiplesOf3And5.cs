using System;

namespace Euler100Classes
{
	public class MultiplesOf3And5
	{
		public int Challenge1()
		{
			int total = 0;
			for (int i = 0; i < 1000; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					total = i + total;
					Console.WriteLine($"The total so far is {total}"); // 233168 should be the final value
				}
			}
			return total;
		}
	}
}
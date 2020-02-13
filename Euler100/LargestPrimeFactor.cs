using System;
using System.Collections.Generic;
using System.Text;

namespace Euler100Classes
{
    public class LargestPrimeFactor
    {
        public long Challenge3(long number)
        {
            while (number % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                number /= 2;
            }
            
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
            }

            if (number > 2)
            {
                Console.WriteLine(number);
            }
            return number;
        }
    }
}

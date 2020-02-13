using System;
using System.Collections.Generic;
using System.Text;

namespace Euler100Classes
{
    public class LargestPrimeFactor
    {
        public long Challenge3(long number)
        {
            // print how many times N goes into 2
            while (number % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                number /= 2;
            }

            // n must be odd at this point.
            // skip one (note:- i = i + 2)
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                // while i divides n, print i and divide n
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
            }

            // this handles the case when n is a prime number > 2 
            if (number > 2)
            {
                Console.WriteLine(number);
            }
            return number;
        }
    }
}

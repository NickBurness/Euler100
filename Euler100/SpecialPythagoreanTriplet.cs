using System;
using System.Collections.Generic;
using System.Text;

namespace Euler100Classes
{
    public class SpecialPythagoreanTriplet
    {
        /* 
         A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
        a2 + b2 = c2

        There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        Find the product abc.

        e.g (3, 4, 5) as 
            ((3*3=9 + 4*4=16) = (5*5 = 25))
         */

        public void Challenge9()
        {
            const int RESULT = 1000;

            for (int a = 1; a <= RESULT; a++)
            {
                for (int b = 1; b <= RESULT; b++)
                {
                    int c = RESULT - a - b;
                    var solution = Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);

                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine($"{a}, {b}, {c}");
                    }
                }
            }
        }
    }
}
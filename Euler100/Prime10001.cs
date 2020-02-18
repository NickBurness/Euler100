using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler100Classes
{
    public class Prime10001
    {
        public int Challenge7()
        {
            int counter = 0;
            int num = 3;

            while (true)
            {
                if (IsPrime(num))
                {
                    counter++;
                }
                if (counter == 10001)
                {
                    break;
                }
                num++;
            }
            return num;
        }

        public static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
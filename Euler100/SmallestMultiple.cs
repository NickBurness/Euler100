using System;
using System.Collections.Generic;
using System.Text;

namespace Euler100Classes
{
    public class SmallestMultiple
    {
        public int Challenge5()
        {
            int num = 2521;

            bool isDivisbleByAll = false;
            bool isFound = false;

            while (isFound != true)
            {
                for (int i = 20; i > 10; i--)
                {
                    if (num % i == 0)
                    {
                        isDivisbleByAll = true;

                    }
                    else
                    {
                        isDivisbleByAll = false;
                        break;
                    }
                }
                if (isDivisbleByAll)
                {
                    break;
                }
                num++;
            }
            return num;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Euler100Classes
{
    public class SumSquareDifference
    {
        public int Challenge6()
        {
            int maxNaturalNumber = 100;
            int sumOfNumbers = 0;
            int sumSquared = 0;

            for (int i = 1; i <= maxNaturalNumber; i++)
            {
                sumOfNumbers += i;
                sumSquared += i * i;
            }
            return (sumOfNumbers * sumOfNumbers) - sumSquared;
        }
    }
}

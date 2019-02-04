using System;
using System.Collections.Generic;

namespace SolveArrays
{
    public class ArraySolver
    {
        public int Sum(int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total = total + number;
            }
            return total;
        }

        public int SumEvens(int[] numbers)
        {
            int evens = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evens = evens + number;
                }
            }
            return evens;
        }

        public double AverageEvens(int[] numbers)
        {
            int evens = 0;
            double average = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evens = evens + number;
                    average = evens / numbers.Length;
                }
            }
            return average;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total = total + number;
                if (total % 2 != 0)
                {
                    return true;
                }
            }
            return true;
        }
    }
}

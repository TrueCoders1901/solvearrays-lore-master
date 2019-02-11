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
            int totalOfEvens = 0;
            int countOfEvens = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    totalOfEvens += number;
                    countOfEvens += 1;
                }
            }

            if (countOfEvens == 0)
            {
                return 0;
            }
            else
            {
                double average = (double)totalOfEvens / countOfEvens;
                return average;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int total = Sum(numbers.ToArray());

            if (total % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

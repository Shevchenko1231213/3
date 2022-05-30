using Lab3.Contracts;
using System;

namespace Lab3.Services
{
    public class NumberService : INumbersRepository
    {
        int[] numbers = { 1, 3, 2, 4, 6, 5 };

        public int[] SortByAscending()
        {
            Array.Sort(numbers);
            return numbers;
        }

        public int[] SortByDescending()
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            return numbers;
        }
    }
}

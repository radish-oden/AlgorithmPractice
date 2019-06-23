using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ShellSort
    {
        public int[]  Shell()
        {
            int[] numbers = { 8, 1, 5, 2, 4, 7, 9, 3, 6, 10 };

            int n = numbers.Length;
            int number;
            for (number = 1; number < n / 9; number = number * 3 + 1) ;
            for (; number > 0; number /= 3)
                for (int i = number; i < n; i++)
                    for (int j = i; j >= number && numbers[j - number].CompareTo(numbers[j]) > 0; j -= number)
                        numbers[j] = numbers[j - number];

            return numbers;
        }


    }
}

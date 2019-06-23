using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class InPlaceSort
    {

        public int[] InPlace()
        {
            int[] numbers = { 8, 1, 5, 2, 4, 7, 9, 3, 6, 10 };
            int number;

            for (int i = 1; i < numbers.Length; i++)
            {
                number = numbers[i];
                if (numbers[i - 1] > number)
                {
                    int j = i;
                    for (; j > 0 && numbers[j - 1] > number; j--)
                    {
                        numbers[j] = numbers[j - 1];
                    }
                    numbers[j] = number;
                }
            }
            return numbers;
        }
    }
}

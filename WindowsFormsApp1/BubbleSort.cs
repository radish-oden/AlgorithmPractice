using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BubbleSort
    {
        public int[] Bubble()
        {
            int[] numbers = { 8, 1, 5, 2, 4, 7, 9, 3, 6, 10 };
            int number;

            Console.Write("ソート前:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i]);
            }
            Console.WriteLine();

            for (int i = 1; i < numbers.Length; i++)
            {
                for (int t = numbers.Length - 1; t >= i; t--)
                {
                    if (numbers[t - 1] > numbers[t])
                    {
                        number = numbers[t - 1];
                        numbers[t - 1] = numbers[t];
                        numbers[t] = number;
                    }
                }
            }

            Console.Write("ソート後:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i]);
            }
            Console.WriteLine();

            return numbers;
        }

    }
}

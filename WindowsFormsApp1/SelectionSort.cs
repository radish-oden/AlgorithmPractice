using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SelectionSort
    {

        public int[] Selection()
        {

            int[] numbers = { 8, 1, 5, 2, 4, 7, 9, 3, 6, 10 };
            int number;


            for (Int32 i = 0; i < numbers.Length - 1; i++)
            {
                Int32 min = i;
                for (Int32 t = i + 1; t < numbers.Length; t++)
                {
                    if (numbers[t] < numbers[min])
                    {
                        min = t;
                    }
                }
                //Swap(ref numbers[i], ref numbers[min]);
            }


            return numbers;
        }

    }
}

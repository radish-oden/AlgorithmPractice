using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SelectionSort
    {

        public int[] Selection()
        {

            int[] numbers = { 8, 1, 5, 2, 4, 7, 9, 3, 6, 10 };
            int number;


            int i; // 配列の先頭を指すインデックス
            int j; // 残りの要素を指すインデックス
            int min; // 最小値を持つ要素のインデックス
            int temp; // 交換用の一時変数

            for (i = 0; i < numbers.Length - 1; i++)
            {
                min = i; // 配列の先頭を最小値の要素とする
                for (j = i + 1; j < numbers.Length; j++)
                { // 比較のループ
                    if (numbers[j] < numbers[min])
                    {
                        min = j; // 最小値を持つ要素を更新
                    }
                }
                // 最小値を持つ要素を先頭の要素と交換
                temp = numbers[i];
                numbers[i] = numbers[min];
                numbers[min] = temp;
            }
            return numbers;
        }
    }
}

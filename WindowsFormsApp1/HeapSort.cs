using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class HeapSort
    {


        public class MargeSortArray
        {
            int[] numbers = { 8, 1, 5, 2, 4, 7, 9, 3, 6, 10 };
            int number;
            private void mergeSortArray(int[] a, int low, int high)
            {
                if (low >= high) { return; }
                int mid = (low + high) / 2;

                mergeSortArray(a, low, mid); //再帰01
                mergeSortArray(a, mid + 1, high); //再帰02

                int[] b = new int[a.Length];
                for (int i = low; i <= mid; i++)
                {
                    b[i] = a[i];
                }

                for (int i = mid + 1, j = high; i <= high; i++, j--)
                {
                    b[i] = a[j];
                }

                int ii = low;
                int jj = high;

                for (int k = low; k <= high; k++)
                {
                    if (b[ii] <= b[jj])
                    {
                        a[k] = b[ii++];
                    }
                    else
                    {
                        a[k] = b[jj--];
                    }
                }
            }

        }
    }
}

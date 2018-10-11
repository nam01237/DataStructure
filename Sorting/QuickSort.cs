using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSort
    {
        public static void Sort(int[] arr, int start, int end)
        {
            if (start <= end)
            {
                int right = Partition(arr, start, end);

                Sort(arr, start, right - 1);
                Sort(arr, right + 1, end);
            }

        }

        private static int Partition(int[] arr, int start, int end)
        {
            if (start >= end)
                return end;

            int pi = (start + end) / 2;
            int pivot = arr[pi];
            
            while (start < end)
            {
                while ((pivot >= arr[start]) && (start < pi))
                    start++;

                while ((pivot <= arr[end]) && (end > pi))
                    end--;

                Swap(ref arr[start], ref arr[end]);
                
                if (end == pi)
                {
                    pi = start;
                    continue;
                }
                if (start == pi)
                    pi = end;
                
            }

            return end;
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }

}

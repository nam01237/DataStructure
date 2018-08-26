using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Sort
    {
        public static void SwapInt(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        public static void BubbbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if( arr[j] > arr[j + 1])
                    {
                        SwapInt(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length - 1;
            int minIndex;

            for (int i = 0; i < n; i++)
            {
                minIndex = i;

                for(int j = i + 1; j <= n; j++)
                {
                    if (arr[minIndex] > arr[j])
                        minIndex = j;
                }

                SwapInt(ref arr[i], ref arr[minIndex]);
            }
        }

        public static void InsertSort(int[] arr)
        {
            int pivot;

            for(int i = 1; i < arr.Length; i++)
            {
                pivot = arr[i];
                int j;

                for(j = i - 1; j >= 0; j--)
                {
                    if (pivot < arr[j])
                        arr[j + 1] = arr[j];
                    else
                        break;
                }

                arr[j + 1] = pivot;
            }
        }
    }
}

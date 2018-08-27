using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeSort
    {
        public static void Sort(int[] arr, int left, int right)
        {
            int mid = (left + right) / 2;

            if( left < right )
            {
                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int i = 0;
            int li = left;
            int ri = mid + 1; ;
            int[] buffer = new int[right - left + 1];

            while( (li <= mid) && (ri <= right ))
            {
                if (arr[li] < arr[ri])
                    buffer[i] = arr[li++];
                else
                    buffer[i] = arr[ri++];

                i++;
            }

            if ( li > mid )
            {
                while(ri <= right)
                {
                    buffer[i] = arr[ri++];
                    i++;
                }
            }
            else
            {
                while(li <= mid)
                {
                    buffer[i] = arr[li++];
                    i++;
                }
            }

            i = 0;
            for(int j = left; j <= right; j++)
            {
                arr[j] = buffer[i++];
            }


        }
    }

}

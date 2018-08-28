using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bubble = { 4, 8, 1, 11, 5, 3, 2, 10 };
            Sort.BubbbleSort(bubble);

            foreach (var item in bubble)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            int[] selection = { 4, 8, 1, 11, 5, 3, 2, 10 };
            Sort.SelectionSort(selection);

            foreach (var item in selection)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            int[] insert = { 4, 8, 1, 11, 5, 3, 2, 10 };
            Sort.InsertSort(insert);

            foreach (var item in insert)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            int[] merge = { 4, 8, 1, 11, 5, 3, 2, 10 };
            MergeSort.Sort(merge, 0, merge.Length - 1);

            foreach (var item in merge)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            int[] quick = { 8, 8, 8, 4, 11, 9, 3};
            QuickSort.Sort(quick, 0, quick.Length - 1);

            foreach (var item in quick)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}

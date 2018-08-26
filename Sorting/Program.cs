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
            int[] bubble = { 4, 8, 1, 11, 5 };
            Sort.BubbbleSort(bubble);

            foreach (var item in bubble)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            int[] selection = { 4, 8, 1, 11, 5 };
            Sort.SelectionSort(selection);

            foreach (var item in selection)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            int[] insert = { 4, 8, 1, 11, 5 };
            Sort.InsertSort(insert);

            foreach (var item in insert)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}

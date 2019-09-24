using System;
using DataStructures.Algorithms;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble sort (10,5,6,9,14,2)");
            int[] numberArray = { 10, 5, 6, 9, 14, 2 };
            var Bubble = new BubbleSort();
            Bubble.Sort(numberArray);
            foreach (int number in numberArray)
            {
                Console.Write($" { number }  ");
            }
            Console.WriteLine("\n ============================= \n");
            Console.WriteLine("Insertion sort (10,5,6,9,14,2)");
            int[] insertionSortArray = { 10, 5, 6, 9, 14, 2 };
            var iSortArray = new InsertionSort();
            iSortArray.Sort(insertionSortArray);
            foreach (int number in insertionSortArray)
            {
                Console.Write($" { number } ");
            }
            Console.WriteLine("\n ============================= \n");
            Console.WriteLine("Selection sort (10,5,6,9,14,2)");
            int[] selectSortArray = { 10, 5, 6, 9, 14, 2 };
            var sSortArray = new InsertionSort();
            sSortArray.Sort(selectSortArray);
            foreach (int number in selectSortArray)
            {
                Console.Write($" { number } ");
            }
            Console.Write("\n");        }
    }
}

using System;
using HW_2;

namespace HW_2
{
    internal class Program
    {
        static void printArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            printArray(arr);
            Sorts.insertionSort(arr, arr.Length);
            printArray(arr);

            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

            printArray(array);
            Sorts.selectionSort(array, array.Length, 0);
            printArray(array);


            ArrayQueue<string> queue = new ArrayQueue<string>();

            queue.Enqueue("Hello");
            queue.Enqueue("World!");

            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
        }
    }
}


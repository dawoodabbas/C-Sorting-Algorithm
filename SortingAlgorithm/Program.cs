using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arrayInt = new int[20];
            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = random.Next(1, 20);
            }
            Console.WriteLine("Randiom Numbers");

            displayArray(arrayInt);
            Console.WriteLine("\n\nSort the array");
            sorting(arrayInt);

            displayArray(arrayInt);

            Console.WriteLine("\n\nFisher yates shuffle");
            int temp = 0;
            for (int i = arrayInt.Length - 1; i > 0; i--)
            {
                temp = random.Next(0, arrayInt.Length);
                swap(arrayInt, i, temp);
            }
            displayArray(arrayInt);

            Console.WriteLine("\n\nQuick Sort");

            quickSort(arrayInt);

            //Console.WriteLine("\n\nQuick Sort");
            //Console.WriteLine(arrayInt.Length - 1);
            displayArray(arrayInt);

            Console.ReadLine();

        }

        static void swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        static void quickSort(int[] array)
        {
            quickSort(array, 0, array.Length - 1);
        }
        static void quickSort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = array[(start + end) / 2];
            int pIndex = partition(array, start, end, pivot);
            quickSort(array, start, pIndex - 1);
            quickSort(array, pIndex, end);

        }

        static int partition(int[] array, int start, int end, int index)
        {
            while (start < end)
            {
                while (array[start] < index)
                {
                    start++;
                }
                while (array[end] > index)
                {
                    end--;
                }
                if (start <= end)
                {
                    swap(array, start, end);
                    start++;
                    end--;

                }
            }
            return start;

        }
        static void sorting(int[] arrayInt)
        {
            int temp = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                for (int j = 0; j < arrayInt.Length; j++)
                {
                    if (arrayInt[i] < arrayInt[j])
                    {
                        temp = arrayInt[i];
                        arrayInt[i] = arrayInt[j];
                        arrayInt[j] = temp;
                    }
                }
            }
        }

        static void displayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
        }
    }
}

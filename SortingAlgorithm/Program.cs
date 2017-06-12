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

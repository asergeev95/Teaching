using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 7;
            var array = CreateRandomArray(n);
            DisplayArray(array);

            //1, 2, 4, 5
            //k = 2, number = 100
            //1, 2, 100, 4, 5
            
            //Exercise3(n, array);
            //Exercise13(n, array);
            //Exercise12(array);
        }

        private static void Exercise3(int n, int[] array)
        {
            var k = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 3 == 0)
                {
                    k++;
                }
            }

            Console.WriteLine(k);
        }

        private static void Exercise13(int n, int[] array)
        {
            var k = 3;
            var newArray = new int[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                if (i < k)
                {
                    newArray[i] = array[i];
                }
                else
                {
                    newArray[i] = array[i + 1];
                }
            }

            DisplayArray(newArray);
        }

        private static void Exercise12(int[] array)
        {
            var k = 3;
            var m = 5;

            var c = array[k];
            array[k] = array[m];
            array[m] = c;

            DisplayArray(array);
        }

        static void DisplayArray(IEnumerable<int> array)
        {
            Console.WriteLine(string.Join(", ", array));
        }

        static int[] CreateRandomArray(int n)
        {
            var array = new int[n];
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(10, 100);
            }

            return array;
        }
    }
}
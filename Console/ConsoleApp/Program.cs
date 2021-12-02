using System;
using System.Collections.Generic;
using ConsoleApp.Models.UniqueModels;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var n = 5;
            // var intArray = new int[5];
            // FillArrayWithRandomNumbers(n, intArray);
            // DisplayArray(intArray);
            var array = new[,]{{10, 5, 4, 7}, {12, 15, 20, 8}, {9, 3, 88, 25}, {50, 60, 70, 80}}; //TwoDimensionArrayHelper.Create2DArray(3, 3);
            TwoDimensionArrayHelper.Display2DArray(array);
            //TwoDimensionArrayHelper.Exercise41(array);
            //TwoDimensionArrayHelper.Exercise51(array);
            TwoDimensionArrayHelper.Exercise54(array);

            //Exercise19(n, intArray);
            //Exercise18(n, intArray);
            //Exercise9And10(intArray, n);
            //Exercise13(n, intArray);
        }

        private static void Exercise19(int n, int[] intArray)
        {
            //2, 2, 5, 4, 7
            var flag = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (intArray[i] <= intArray[i + 1])
                {
                    continue;
                }
                else
                {
                    flag = false;
                }
            }

            Console.WriteLine(flag);
        }

        private static void Exercise18(int n, int[] intArray)
        {
            var elementToInsert = Console.ReadLine();
            var k = 2;
            var newArray = new int[n + 1];
            for (var i = 0; i < n + 1; i++)
            {
                if (i < k)
                {
                    newArray[i] = intArray[i];
                }
                else
                {
                    if (i == k)
                    {
                        newArray[i] = int.Parse(elementToInsert);
                    }
                    else
                    {
                        newArray[i] = intArray[i - 1];
                    }
                }
            }

            DisplayArray(newArray);
        }

        private static void Exercise9And10(int[] intArray, int n)
        {
            var max = -1;
            var maxIndex = -1;
            for (var i = 0; i < n; i++)
            {
                if (intArray[i] > max)
                {
                    max = intArray[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(maxIndex);
        }

        private static void Exercise13(int n, int[] intArray)
        {
            var newArray = new int[n - 1];
            var k = 2;
            // 1, 2, 5, 6, 8
            for (var i = 0; i < n - 1; i++)
            {
                if (i < k)
                {
                    newArray[i] = intArray[i];
                }
                else
                {
                    newArray[i] = intArray[i + 1];
                }
            }

            DisplayArray(newArray);
            // 1, 2, 6, 8
        }

        private static void FillArrayWithRandomNumbers(int n, int[] intArray)
        {
            var random = new Random();
            for (var i = 0; i < n; i++)
            {
                var randomNumber = random.Next(10, 100);
                intArray[i] = randomNumber;
            }
        }

        private static void DisplayArray(int[] intArray)
        {
            Console.WriteLine(string.Join(", ", intArray));
        }
    }
}
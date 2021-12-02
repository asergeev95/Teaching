using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public static class TwoDimensionArrayHelper
    {
        public static int[,] Create2DArray(int n, int m)
        {
            var array = new int[n, m];
            FillArrayWithRandomNumbers(array);
            return array;
        }

        // Dictionary 
        public static void Exercise41(int[,] intArray)
        {
            var n = intArray.GetLength(0);
            var m = intArray.GetLength(1);
            var dictionary = new Dictionary<int, int>();
            /*
             * i = 2
             * j = 1;
             *   4, 3, 5 
             *   8, 4, 2
             *   3, 1, 7
             *
             * 4 5
             * 8 2
             *
             *   { 1:2, 3:1, ....  }
             */
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    var currentElement = intArray[i, j];
                    if (dictionary.ContainsKey(currentElement))
                    {
                        dictionary[currentElement] = dictionary[currentElement] + 1;
                    }
                    else
                    {
                        dictionary.Add(currentElement, 1); //currentElement - ключ,
                        //dictionary[currentElement] - значение
                    }
                }
            }

            foreach (var (key, value) in dictionary)
            {
                if (value == 1)
                {
                    Console.WriteLine(key);
                }
            }
        }

        public static void Exercise51(int[,] array)
        {
            var n = array.GetLength(0);
            var m = array.GetLength(1);
            var lastColumnArray = new int[n];
            //сохранили последний столбец в отдельный массив
            for (var i = 0; i < n; i++)
            {
                lastColumnArray[i] = array[i, m - 1];
            }

            //скопировали 1й столбец во 2й, 2й в 3й и тд
            //n = 3, m = 3
            for (var j = m - 1; j > 0; j--)
            {
                for (var i = 0; i < n; i++)
                {
                    array[i, j] = array[i, j - 1];
                }
            }


            //1й столбец заполнили значениями из последнего
            for (var i = 0; i < n; i++)
            {
                array[i, 0] = lastColumnArray[i];
            }

            Console.WriteLine();
            Display2DArray(array);
        }

        public static void Exercise54(int[,] array)
        {
            var n = array.GetLength(0);
            var m = array.GetLength(1);
            var minElement = 101;
            var minElementIndex = (0, 0); //tuple 
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                        minElementIndex = (i, j);
                    }
                }
            }

            var newArray = Create2DArray(n - 1, m);
            var lineIndexToDelete = minElementIndex.Item1;
            var columnIndexToDelete = minElementIndex.Item2;
            for (var i = 0; i < n - 1; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    if (i < lineIndexToDelete)
                    {
                        newArray[i, j] = array[i, j];
                    }

                    if (i >= lineIndexToDelete)
                    {
                        newArray[i, j] = array[i + 1, j];
                    }
                }
            }
            
            var newArrayWithoutColumn = Create2DArray(n - 1, m-1);
            for (var j = 0; j < m - 1; j++)
            {
                for (var i = 0; i < n-1; i++)
                {
                    if (j < columnIndexToDelete)
                    {
                        newArrayWithoutColumn[i, j] = newArray[i, j];
                    }

                    if (j >= columnIndexToDelete)
                    {
                        newArrayWithoutColumn[i, j] = newArray[i, j + 1];
                    }
                }
            }
            Console.WriteLine();
            Display2DArray(newArrayWithoutColumn);
        }

        public static void Display2DArray(int[,] intArray)
        {
            var n = intArray.GetLength(0);
            var m = intArray.GetLength(1);
            for (var i = 0; i < n; i++)
            {
                var lineElements = new List<int>();
                for (var j = 0; j < m; j++)
                {
                    lineElements.Add(intArray[i, j]);
                }

                Console.WriteLine(string.Join("\t", lineElements));
            }
        }

        private static void FillArrayWithRandomNumbers(int[,] intArray)
        {
            var random = new Random();
            var n = intArray.GetLength(0);
            var m = intArray.GetLength(1);
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    var randomNumber = random.Next(10, 100);
                    intArray[i, j] = randomNumber;
                }
            }
        }
    }
}
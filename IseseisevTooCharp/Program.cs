using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace IseseisevTooCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Action[] methods = new Action[] { Task1 };
                Console.WriteLine("Sisestage ülesanne number");
                string numstr = Console.ReadLine();
                int number = int.Parse(numstr);
                methods[number - 1]();
            }
        }

        private static void Task1()
        {
            int rows = 5;
            int columns = 5;
            int[,] array = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }

            Console.WriteLine("Algne massiiv:");
            PrintArray(array);

            for (int i = 0; i < rows; i++)
            {
                int[] row = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    row[j] = array[i, j];
                }

                if (i % 2 == 0)
                    Array.Sort(row);
                else
                    Array.Sort(row, (a, b) => b.CompareTo(a));

                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = row[j];
                }
            }

            Console.WriteLine("\nSortitud massiiv:");
            PrintArray(array);

            Console.Write("\nSisestage veeru number väljundiks (0 kuni " + (columns - 1) + "): ");
            int k = int.Parse(Console.ReadLine());

            if (k < 0 || k >= columns)
            {
                Console.WriteLine("Vale veeru number.");
                return;
            }

            Console.WriteLine($"\nVäärtused veerus {k}:");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(array[i, k]);
            }
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

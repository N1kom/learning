using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3] { { 1, 5, 2 }, { 7, 3, 2 }, { 9, 3, 5 } };

            Console.WriteLine(array.GetLength(0) + " - Колличество строк массива.");
            Console.WriteLine(array.GetLength(1) + " - Колличество столбцов массива.");
            int sum = 0;
            int multiply = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 1)
                    {
                        sum += array[i, j];
                    }
                    if (j == 0)
                    {
                        multiply *= array[i, j];
                    }
                    if (i > 1 && j == 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sum + " - сумма элементов второй строки.");
            Console.WriteLine(multiply + " - произведение элементов первого столбца.");
        }
    }
}


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
               int[,] array = new int[10, 10];
                Random mas = new Random();
                int max = array[0, 0];
                Console.WriteLine("массив случайных чисел:");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = mas.Next(1, 100);
                    if (max < array[i, j])
                        max = array[i, j];
                        Console.Write("{0} ",array[i, j]);
                    }
                    Console.WriteLine();
                }
            Console.WriteLine(max + " - максимальный элемент массива");
            Console.WriteLine("Измененный массив случайных чисел:");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] == max) array[i, j] = 0;
                        Console.Write("{0} ", array[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
}

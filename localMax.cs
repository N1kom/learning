using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
                Console.Write(array[i] + " ");
            }
            
            Console.SetCursorPosition(0, 2);
            
                        for (int b = 0; b < array.Length; b++)
            {
                int localMax;
                if (b == 0 && array[b] > array[b + 1])
                {
                    localMax = array[b];
                    Console.WriteLine(localMax);
                    b += 2;
                }
                else if (b == array.Length - 1 && array[b] > array[b - 1])
                {
                    localMax = array[b];
                    Console.WriteLine(localMax);
                    b += 2;
                }
                else if (b != 0 && b != array.Length - 1 && array[b] > array[b - 1] && array[b] > array[b + 1])
                {
                    localMax = array[b];
                    Console.WriteLine(localMax);
                    b += 2;
                }
            }
        }
    }
}


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
           
            int[] array = new int[0];
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == "exit")
                {
                    break;
                }
                else if (userInput == "sum")
                {
                    int sum = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                    }
                    Console.WriteLine($"Сумма введеных чисел - {sum}");
                }
                else
                {
                    int[] tempArray = new int[array.Length + 1];
                    int userNumbers = Convert.ToInt32(userInput);
                    tempArray[tempArray.Length - 1] = userNumbers;
                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }
                    array = tempArray;
                }
            }
        }
    }
}

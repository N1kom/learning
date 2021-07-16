using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            char symbol;

            Console.Write("Name - ");

            name = Console.ReadLine();

            Console.Write("Symbol - ");

            symbol = Convert.ToChar(Console.ReadLine());

            int lenght = name.Length+2;

            for (int i = lenght; i >=1; i--) 
            { 
                Console.Write(symbol);

                if (i == 1)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"{symbol}{name}{symbol}");
                }
            }

            for (int i = lenght; i >= 1; i--)
            {
                Console.Write(symbol);

                if (i == 1)
                {
                    Console.WriteLine(" ");
                    Console.ReadKey();
                }

            }

        }
    }
}

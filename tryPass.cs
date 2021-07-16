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
            string password = "Bern";
            string userInput;

            Console.WriteLine("Введите пароль для получения секретных данных." +
                "\nПаролем является название Столицы Швейцарии(де факто)" +
                "\nУ вас есть три попытки.");

            for (int i = 2; i >=0; i--)
            {
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("Данных не подвезли,но ты молодец,что знаешь такой город.");

                    break;
                }
                
                Console.WriteLine($"Неверно. Осталось {i} попыток.");
            
            }


        }
    }
}

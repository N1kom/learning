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
            
            Console.WriteLine("Хочешь увидеть магию?)");
            Console.WriteLine("1.ДА\n2.Нет");

            string userInput = Console.ReadLine();

            int i = 1;

            switch(userInput)
            {
                case "1":
                    while (userInput != "exit")
                    {

                        Console.WriteLine($"абракадабра {i++}.");
                        Console.WriteLine("Что бы выйти набери команду - exit");

                        userInput = Console.ReadLine();

                    }

                    break;

                case "2":

                    Console.WriteLine("введи число - 221324,если не боишься," +
                        "\nа если боишься,то жмякай,что хочешь");

                    userInput = Console.ReadLine();

                    if (userInput == "221324")
                    {
                        Console.WriteLine("После следующего сообщения введи код - 123.");
                    }
                  
                    break;
            
            }
          
            Console.WriteLine("сцуко,работает!");


            userInput = Console.ReadLine();

            if (userInput == "123")
            {
                Console.WriteLine("Вот честное слово,лучше бы ты взглянул на магию.");
            
            }


        }
    }
}

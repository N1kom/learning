using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Привет,как тебя зовут?");
            string userName = Console.ReadLine();

            Console.Write($"Скажи {userName},а сколько тебе лет?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.Write($"А кто ты по знаку зодиака,{userName}?");
            string userSign = Console.ReadLine();

            Console.Write($"{userName},а где ты работаешь?");
            string userJob = Console.ReadLine();

            Console.WriteLine($"И так,тебя зовут {userName},тебе {userAge} лет,по знаку зодиака ты {userSign} и работаешь на {userJob}.");


        }
    }
}

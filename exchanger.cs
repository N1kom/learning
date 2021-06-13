using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            // конвертер 3ёх валют,кол-во имеющихся валют задаются пользователем,отношение валют друг к другу уже имеются.

            // Console.WriteLine("Во имя короля,что здесь происходит?! Кто ты и что ты тут делаешь?!");

            //int userAnswer = 1;

            // Console.WriteLine($"{userAnswer}. Я прибыл издалека и хотел бы обменять "

            int rubToUsd = 73, usdToRub = 71, rubToEuro = 85, euroToRub = 82, usdToEuro = 3, euroToUsd = 1;

            string userInput;
            float exchangeCount;

            Console.WriteLine("Бла бла бла,добро пожаловать,сейчас мы поимеем с вас небольшой гешефт!");

            Console.WriteLine("Введите колличество рублей:");
            float rub = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите колличество долларов:");
            float usd = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите колличество евро:");
            float euro = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"У вас есть: \n{rub} рублей. \n{usd} долларов. \n{euro} евро.");
            
            Console.WriteLine("Какую операцию вы хотите совершить?\n1 - Обменять рубли на доллары. \n2 - Обменять доллары на рубли. " +
                "\n3 - Обменять рубли на евро. \n4 - Обменять евро на рубли. \n5 - Обменять доллары на евро. \n6 - Обменять евро на доллары.");
            userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары.");
                    Console.WriteLine("Сколько рублей вы хотите поменять?");

                    exchangeCount = Convert.ToSingle(Console.ReadLine());

                    if (exchangeCount <= rub)
                    {
                        rub -= exchangeCount;
                        usd += exchangeCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно рублей.");
                        
                    }
                    break;

                case "2":
                    Console.WriteLine("Обмен долларов на рубли.");
                    Console.WriteLine("Сколько долларов вы хотите поменять?");

                    exchangeCount = Convert.ToSingle(Console.ReadLine());

                    if (exchangeCount <= usd)
                    {
                        usd -= exchangeCount;
                        rub += exchangeCount / usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно долларов.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Обмен рублей на евро.");
                    Console.WriteLine("Сколько рублей вы хотите поменять?");

                    exchangeCount = Convert.ToSingle(Console.ReadLine());

                    if (exchangeCount <= rub)
                    {
                        rub -= exchangeCount;
                        euro += exchangeCount /rubToEuro;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно рублей.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Обмен евро на рубли.");
                    Console.WriteLine("Сколько евро вы хотите поменять?");

                    exchangeCount = Convert.ToSingle(Console.ReadLine());

                    if (exchangeCount <= euro)
                    {
                        euro -= exchangeCount;
                        rub += exchangeCount / euroToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно евро.");
                    }
                    break;

                case "5":
                    Console.WriteLine("Обмен долларов на евро.");
                    Console.WriteLine("Сколько долларов вы хотите поменять?");

                    exchangeCount = Convert.ToSingle(Console.ReadLine());

                    if (exchangeCount <= usd)
                    {
                        usd -= exchangeCount;
                        euro += exchangeCount / usdToEuro;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно долларов.");
                    }
                    break;

                case "6":
                    Console.WriteLine("Обмен долларов на евро.");
                    Console.WriteLine("Сколько долларов вы хотите поменять?");

                    exchangeCount = Convert.ToSingle(Console.ReadLine());

                    if (exchangeCount <= euro)
                    {
                        euro -= exchangeCount;
                        usd += exchangeCount / euroToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно евро.");
                    }
                    break;

            }
                    
            Console.WriteLine($"Ваш баланс:\n{rub} рублей.\n{usd}долларов.\n{euro} евро.");
            //Console.WriteLine("1 - продолжить обмен волюты.\n2 - Завершить операцию.");



        }
    }
}

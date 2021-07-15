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
          

           

            int password = 0;
            int rank = 0;
            string name = " ";
            int age = 0;

            Console.WriteLine("1.Set Name - задать имя сотрудника." +
                "\n2.Password - задать личный пароль сотрудника." +
                "\n3.Rank - задать уровень доступа сотрудника." +
                "\n4.Age - указать возраст сотрудника." +
                "\n5.Write Information - вывести инфо. о сотруднике." +
                "\n6.Esc - выйти из программы.");

            string userInput;

            while ((userInput = Console.ReadLine()) != "Esc")
            {
                
                switch (userInput)
                {
                    case "Set Name":

                        name = Console.ReadLine();

                        Console.WriteLine("name");

                        break;

                    case "Rank":

                        rank = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("rank");

                        break;

                    case "Age":

                        age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("age");

                        break;

                    case "Password":

                        password = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("password");

                        break;

                    case "Write Information":

                        Console.WriteLine("Что бы получить информацию введите пароль");

                        for (int tryPass = 1; tryPass != password;)
                        {
                            tryPass = Convert.ToInt32(Console.ReadLine());

                            if (tryPass == password)
                            {
                                Console.WriteLine($"Имя сотрудника {name}." +
                                    $"\n Возраст сотрудника {age}." +
                                    $"\n Доступ сотрудника {rank}");
                            }

                            Console.WriteLine("Неверный пароль.Попробуйте ещё раз.");
                        }

                        break;

                    default: 

                        Console.WriteLine("Неизвестная команда!");

                        break;
                }
            }

            
           






        }
    }
}

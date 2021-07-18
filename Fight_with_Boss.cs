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
            Random rand = new Random();
            float playerHealth = 100;
            float playerArmor = rand.Next(50, 85);
            float playerDamage = rand.Next(50, 80);

            int bloodCurse;
            int bloodForce = 100;
            
            float bossHealth = 1000;
            int bossDamage = rand.Next(30, 40);
            float bossArmor = rand.Next(70, 100);

            int critChance = rand.Next(0, 100);
            float damageDone;
            string userInput;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Статы Игрока:" +
                $"\nЖизнь {playerHealth}" +
                $"\nЗащита {playerArmor}" +
                $"\nУрон {playerDamage}");


            Console.SetCursorPosition(20,0);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Статы Противника:");
            Console.SetCursorPosition(20, 1);
            Console.WriteLine($"Жизнь {bossHealth}");
            Console.SetCursorPosition(20, 2);
            Console.WriteLine($"Защита {bossArmor}");
            Console.SetCursorPosition(20, 3);
            Console.WriteLine ($"Урон {bossDamage}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("У тебя есть 4 заклинания,используя и комбинируя которые,ты сможешь одержать победу над противником.");
            Console.WriteLine("1.Blood Force - наносит урон 100,есть шанс 30% критического урона(х2)." +
                "\n2.Blood Stand - боевая стойка война крови -10хп + 20% к защите,возможность использовать спелл 3 Время действия 3 хода." +
                "\n3.Blood Heal - востановление здоровья - 50% к урону + 30хп(только в стойке Blood Stand)." +
                "\n4.Blood Curse - Проклятье крови - наносит урон от 10 до 100 хп.");


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nНажмите любую клавишу для начала поединка!");

            Console.ReadKey();

            while (playerHealth >= 0 && bossHealth >= 0)
            {
                bloodCurse = rand.Next(10, 100);
                critChance = rand.Next(0, 100);

                if (critChance >= 95)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    damageDone = Convert.ToSingle(bossDamage * 1.5) / 100 * playerArmor;
                    playerHealth -= damageDone;

                    Console.WriteLine($"\nКрит!!! Босс нанёс вам {damageDone} урона.");
                    Console.WriteLine($"Ваше здоровье {playerHealth}.");

                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    damageDone = Convert.ToSingle(rand.Next(0, bossDamage)) / 100 * playerArmor;
                    playerHealth -= damageDone;

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\nБосс нанёс вам {damageDone} урона.");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ваше здоровье {playerHealth}.");

                    damageDone = Convert.ToSingle(rand.Next(0, (int)playerDamage)) / 100 * bossArmor;
                    bossHealth -= damageDone;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nВы нанесли боссу {damageDone} урона.");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Здоровье Босса {bossHealth}.");

                    Console.ForegroundColor = ConsoleColor.White;

                }

                switch (userInput = Console.ReadLine())
                {
                    case "Blood Force":

                        if (critChance >= 70)
                        {
                            
                            damageDone = Convert.ToSingle(bloodForce * 2) / 100 * bossArmor;
                            bossHealth -= damageDone;

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\nКрит!!! Вы нанесли боссу {damageDone} урона.");

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"Здоровье Босса {bossHealth}.");
                          
                        }

                        else
                        {
                           
                            damageDone = Convert.ToSingle(bloodForce) / 100 * bossArmor;
                            bossHealth -= damageDone;

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nВы нанесли боссу {damageDone} урона.");

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"Здоровье Босса {bossHealth}.");

                            damageDone = Convert.ToSingle(rand.Next(0, bossDamage)) / 100 * playerArmor;
                            playerHealth -= damageDone;

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"Босс нанёс вам {damageDone} урона.");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Ваше здоровье {playerHealth}.");
                        }

                        break;

                    case "Blood Stand":

                        playerHealth -= 10;
                        playerArmor -= playerArmor * 0.2f;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nВы приняли стойку война крови! Ваше здоровье {playerHealth},ваша броня {playerArmor} .");

                        for (int i = 0; i <= 2; i++)
                        {
                            damageDone = Convert.ToSingle(bloodForce) / 100 * bossArmor;
                            bossHealth -= damageDone;

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nВы нанесли боссу {damageDone} урона.");

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"Здоровье Босса {bossHealth}.");

                            damageDone = Convert.ToSingle(rand.Next(0, bossDamage)) / 100 * playerArmor;
                            playerHealth -= damageDone;

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"\nБосс нанёс вам {damageDone} урона.");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Ваше здоровье {playerHealth}.");

                            userInput = Console.ReadLine();

                            if (userInput == "Blood Heal")
                            {
                                playerDamage -= playerDamage * 0.5f;
                                playerHealth += 30;

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\nВы использовали лечение крови! Ваш урон уменьшен и равен { playerDamage},ваше здоровье {playerHealth} .");
                            }
                          

                           
                        }

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nВремя для использования Blood Heal истекло!");

                        break;


                    case "Blood Curse":

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nВы кастуете проклятие крови на босса.");

                        bossHealth -= bloodCurse;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Босс теряет {bloodCurse} здоровья.");

                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Вы незнаете таких заклинаний.");

                        break;

                }


            }

            if (playerHealth <= 0)
            {

                Console.WriteLine("Вас убили.");
            }

            else if (bossHealth <= 0)

            {
                Console.WriteLine("Поздравляю! Вы победили!");
            }

            else if (bossHealth <= 0 && playerHealth <= 0) 
            {
                Console.WriteLine("Мхм...это невозможно.");
            }

            Console.ReadKey();
        }
    }
}

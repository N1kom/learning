using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int card = 52;
            int cardRow = 3;
            int row;
            int surplusCard;

            row = card / cardRow;
            surplusCard = card % row;
            Console.WriteLine($" Картами заполнено {row} рядов и осталось {surplusCard} свободных карт");






        }
    }
}

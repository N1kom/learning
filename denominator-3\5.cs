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
           Random random = new Random();
            int minLimit = 0;
            int maxLimit = 100;
            int maxElement = random.Next(minLimit, maxLimit);
            int firstDenominator =  3;
            int secondDenominator = 5;
            int sum=0;
            Console.WriteLine(maxElement + " - число бога.");

            for (int i = 0; i < maxElement ; i++)
            {
                if (i%firstDenominator == 0 || i % secondDenominator == 0)
                {
                 sum+=i;
                }
            }
            Console.WriteLine(sum + "- Сумма кратная 3ём и 5ти.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NL
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random rand = new Random();
            int denominator = rand.Next(1,27);
            int count = 0;
            int uplimit = 1000;
            int downlimit = 99;
            int sum=0;
            while (sum<uplimit)
            {
                    sum += denominator;
                    if (sum < uplimit && sum > downlimit)
                    { 
                    count ++;
                    Console.WriteLine(sum);
                     }
                }
            Console.WriteLine(count + " - колличество трёхзначных чисел кратных " + denominator);
        }
    }
}

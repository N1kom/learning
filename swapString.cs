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
            string name = "Pupkin";
            string surname = "Vasya";

            (name, surname) = (surname, name);
            Console.WriteLine(surname + " " + name);
        }
    }
}

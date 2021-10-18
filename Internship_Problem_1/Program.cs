using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_Problems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fighter fighter1 = new Fighter("Marius", 100, 21);
            Fighter fighter2 = new Fighter("Miron", 90, 25);
            Console.WriteLine(Kata.DeclareWinner(fighter1, fighter2, "Marius"));

        }
    }
}

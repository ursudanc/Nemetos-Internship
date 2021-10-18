using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_Problems
{
    public class Kata
    {
        public static string DeclareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            if (fighter1.Name == firstAttacker)
            {
                // Console.WriteLine("fighter 1 health:" + fighter1.Health);
                //  Console.WriteLine("fighter 2 health:" + fighter2.Health+"\n");
                while (fighter1.Health >= 0 && fighter2.Health >= 0)
                {
                    fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;
                    if (fighter2.Health <= 0)
                        break;
                    fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;
                }

                //  Console.WriteLine("\nfighter 1 health:" + fighter1.Health);
                //  Console.WriteLine("fighter 2 health:" + fighter2.Health);

            }
            else
            {
                //Console.WriteLine("fighter 1 health:" + fighter1.Health);
                // Console.WriteLine("fighter 2 health:" + fighter2.Health + "\n");
                while (fighter1.Health >= 0 && fighter2.Health >= 0)
                {
                    fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;
                    if (fighter1.Health <= 0)
                        break;
                    fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;
                }
                //  Console.WriteLine("\nfighter 1 health:" + fighter1.Health);
                // Console.WriteLine("fighter 2 health:" + fighter2.Health);

            }
            if (fighter1.Health > 0)

                return fighter1.Name;
            else
                return fighter2.Name;
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace Internship_Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new Evaluator().Evaluate("2-20-1*(7-2)"));
            Console.WriteLine(new Evaluator().Evaluate("2+10+100/500"));
            Console.WriteLine(new Evaluator().Evaluate("3+3+3+3*50+(10-9*3)"));


        }
    }
}

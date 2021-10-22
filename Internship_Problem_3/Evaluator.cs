using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Internship_Problem_3
{

    class Evaluator
    {
        public double Evaluate(string expresion)
        {
            string newword = Regex.Replace(expresion, @"\s+", "");
            char[] tokens = expresion.ToCharArray();
            Stack<double> valori = new Stack<double>();
            Stack<char> semne = new Stack<char>();

            for (int i = 0; i < tokens.Length; i++)
            {
                
                if (tokens[i] >= '0' && tokens[i] <= '9')
                {
                    double nr = 0;
                    while (i < tokens.Length && tokens[i] >= '0' && tokens[i] <= '9')
                    {
                        nr = nr * 10 + (double)(tokens[i] - '0');
                        i++;
                    }
                    valori.Push(nr);
                    i--;
                }
                else if (tokens[i] == '(')
                {
                    semne.Push(tokens[i]);
                }
                else if (tokens[i] == ')')
                {
                    while (semne.Peek() != '(')
                    {
                        valori.Push(calcOperatii(semne.Pop(),
                                         valori.Pop(),
                                        valori.Pop()));
                    }
                    semne.Pop();
                }

                else if (tokens[i] == '+' || tokens[i] == '-' || tokens[i] == '*' || tokens[i] == '/')
                {
                    while (semne.Count > 0 &&
                             Predecesor(tokens[i],
                                         semne.Peek()))
                    {
                        valori.Push(calcOperatii(semne.Pop(),
                                         valori.Pop(),
                                       valori.Pop()));
                    }
                    semne.Push(tokens[i]);
                }
            }

            while (semne.Count > 0)
            {
                valori.Push(calcOperatii(semne.Pop(),
                                 valori.Pop(),
                                valori.Pop()));
            }
            return valori.Pop();
        }
        public static bool Predecesor(char op1,
                                         char op2)
        {
            if (op2 == '(' || op2 == ')')
                return false;
            
            if ((op1 == '*' || op1 == '/') &&
                   (op2 == '+' || op2 == '-'))
                return false;
            
            else
                return true;
          
        }
        public static double calcOperatii(char op,
                                double b, double a)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
            }
            return 0;
        }
    }
}

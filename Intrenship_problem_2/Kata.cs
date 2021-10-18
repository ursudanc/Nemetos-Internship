﻿using System;
using System.Collections.Generic;
using System.Text;
namespace Intrenship_problem_2

{

    public class Kata
    {
        public static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 0:
                    return "no one likes this";
              
                case 1:
                    return name[0] + " likes this";
                
                case 2:
                    return name[0] + " and " + name[1] + " like this";
                
                case 3:
                    return name[0] + ", " + name[1] + " and " + name[2] + " like this";
                    
                default:
                    int i = name.Length - 2;
                    return name[0] + ", " + name[1] + " and " + i + " others like this";
                   
            }

            throw new NotImplementedException();
        }
    }

}

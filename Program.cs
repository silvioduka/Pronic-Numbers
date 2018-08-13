/*
Pronic Numbers from Coding Challenges
by Silvio Duka

Last modified date: 2018-02-23

Pronic number is a number which is the product of two consecutive integers, that is, n=x*(x+1). 
Write a program which, for a given input n, detect if the number is pronic or not. 

Some Examples: 
6: True 
42: True 
132: True 
2550: True 
10100: True 
4: False 
66: False 
133: False 
1666: False 
17289: False
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PronicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 10100;     //Insert integer number

            long x = (long)Math.Sqrt(number);

            long result = x * (x + 1);

            Console.WriteLine($"{number}: {(number==result).ToString()}");
        }
    }
}

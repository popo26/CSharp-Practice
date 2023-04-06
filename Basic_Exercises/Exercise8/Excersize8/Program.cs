﻿//8.Write a C# Sharp program that takes a number as input and print its multiplication table
//Test Data:
//Enter the number: 5
//Expected Output:
//5 * 0 = 0
//5 * 1 = 5
//5 * 2 = 10
//5 * 3 = 15....5 * 10 = 50

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize8
{
    internal class Program
    {
        static void Main()
        {
            int num;

            Console.WriteLine("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            { 
                Console.WriteLine("{0}x{1}={2}", num, i, num*i);
            }
            Console.ReadKey();
        }
    }
}

﻿//<auto-generated/>
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class HeadTail
    {
        public static void Toss()
        {
            Console.WriteLine("No of times you wanna toss a coin");
            int no = int.Parse(Console.ReadLine());
            int head = 0;
            int tail = 0;
            for (int i = 1; i <= no; i++)
            {
                Random rand = new Random();
                int j = rand.Next(0, 2);
                if (j == 0)
                {
                    head += 1;
                }
                else
                {
                    tail += 1;
                }
               // Console.WriteLine(head);
            }
           
            double a =( head*100) / no;
            double b =( tail*100)/ no;
           
            double percentageOfHead = a ;
            double percentageOfTail = b;
            
            Console.WriteLine("head % : {0} and tail % : {1}", percentageOfHead,percentageOfTail);
        }
    }
}

﻿//<auto-generated/>
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class LeapYear
    {
        public static void Leap()
        {
            Console.WriteLine("Enter the year");
          int year= Utility.UtiliReadInt();

            if (Utility.UtiliLeapYear(year) == true)
            {
                Console.WriteLine("its a leap year");
            }
            else
            {
                Console.WriteLine("its not a leap year");
            }         
                     }           
    }
 }


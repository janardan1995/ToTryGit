﻿//<auto-generated/>
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class SumOfThree
    {
        public static void Sum()
        {
            Console.WriteLine("enter the length of the array");
            int x = Utility.UtiliReadInt();
            Console.WriteLine("enter the no. in arr -ve and +ve all are accepted");
            int[] array = new int[x];
            for(int i = 0; i < x; i++)
            {
                array[i] = Utility.UtiliReadInt();
            }
            bool found = false;
            for (int i = 0; i < x-2; i++)
            {
                for(int j = i+1; j < x-1; j++)
                {
                    for(int k = j+1; k < x; k++)
                    {
                        if (array[i]+array[j] + array[k] == 0)
                        {
                            Console.Write(array[i ]+ " " + array[j]+" " +array[k] +" ");
                            Console.WriteLine();
                            found = true;
                        }
                        
                    }
                }
                
            }
            if (found == false)
            {
                Console.WriteLine("not found");
            }
        }
    }
}

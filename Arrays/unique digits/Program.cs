﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unique_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[50];
            Random random = new Random();
            
           for (int i = 0; i < 50; i++)
            {
                int randomNum = random.Next(1, 50);
                array[i] = randomNum;
              if( )
                {
                    Console.WriteLine(array[i]);
                }

            }
            Console.WriteLine("");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[50];
            Random random = new Random();
            int i;
            for (i = 0; i < 50; i++)
            {
                int randomNum = random.Next(1, 50);
                array[i] = randomNum;
                if(i % 10 == 0 && i != 0)
                {
                    Console.WriteLine(" " + array[i]);
                }
                else
                {
                    Console.Write(" " + array[i]);
                }
            }
            int small = array[0];
            int big = array[0];
            for(i = 0; i < 50; i++)
            {
                if(array[i] < small)
                {
                    small = array[i];
                }
                if(array[i] > big)
                {
                    big = array[i];
                }
            }
            Console.WriteLine("");
            Console.WriteLine("min: " + small);

            Console.WriteLine("max " + big);

            Console.WriteLine("");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5000];
            Random random = new Random();
            int i;
            for (i = 0; i < 50; i++)
            {
                int randomNum = random.Next(1, 5000);
                array[i] = randomNum;
            }

            int big = array[0];
            int big2 = array[0];
            for (i = 0; i < 5000; i++)
            {

                if (array[i] > big)
                {
                    big = array[i];
                }

            }
            for (i = 0; i < 5000; i++)
            {
                if (array[i] > big2)
                {
                    if (big2 < big)
                    {
                    big2 = array[i];
                    }
                }
            }

            Console.WriteLine("biggest is " + big);
            Console.WriteLine("2nd biggest is " + big2);




        }
    }
}

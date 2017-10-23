using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedupe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5000];
            Random random = new Random();
            int i;
            for(i = 0; i < 5000; i++)
            {
                int randomNum = random.Next(1, 3);
                array[i] = randomNum;
                

            }
            Console.Write(array[]);

        }
    }
}

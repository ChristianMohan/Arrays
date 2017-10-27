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
            int i = 0;
            int p;

            for(p = 0; p< array.Length; p++)
            {
                int randomNum = random.Next(1, 50);
                array[i] = randomNum;
                i++;
            }

            for(i = 0; i < array.Length; i++)
            {

                

                for (int j = i + 1; j <array.Length ; j++)
                {
                    if (array[i] == array[j])
                    {
                        array[i] = -1;
                    }
                    
                }


                Console.Write(array[i] + " ");
                
            }
            



        }
    }
}

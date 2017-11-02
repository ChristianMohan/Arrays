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


            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 51);

            }
            Array.Sort(array);
            int check = 0;

            for(int i = 0; i < array.Length; i++)
            {

                if(check != array[i])
                {
                    check = array[i];
                }
                else
                {
                    array[i] = -1;
                }

                    
                }

            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            

        }
            



        }
    }


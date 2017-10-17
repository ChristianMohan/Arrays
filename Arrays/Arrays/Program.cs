using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           double[] array = new double[100];
            string[] array1 = new string[100];


             for (int i = 0; i < 100; i++)
            {
                array[i] = i; 
                array1[i] = "";
                if (array[i] % 3 == 0)
                {
                    array1[i] = array1[i] + "fizz"; 
                }
                if (array[i] % 5 == 0)
                {
                    array1[i] = array1[i] + "buzz";
                }
                Console.WriteLine(array[i] + " . " + array1[i]);
            }
            Console.WriteLine("hi");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {


            String[] tic = new String[9];

            for (int i = 0; i < 9; i++)
                {
                    tic[i] = "   ";
                }

                
            
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("Player X, wwhare do you want to move?");
                String t1 = Console.ReadLine();
                if (t1 == "1a")
                {
                    tic[0] = " x ";
                }
                if (t1 == "2a")
                {
                    tic[3] = " x ";
                }
                if (t1 == "3a")
                {
                    tic[6] = " x ";
                }
                if (t1 == "1b")
                {
                    tic[1] = " x ";
                }
                if (t1 == "2b")
                {
                    tic[4] = " x ";
                }
                if (t1 == "3b")
                {
                    tic[7] = " x ";
                }
                if (t1 == "1c")
                {
                    tic[2] = " x ";
                }
                if (t1 == "2c")
                {
                    tic[5] = " x ";
                }
                if (t1 == "3c")
                {
                    tic[8] = " x ";
                }
                else
                {
                
               
                    Console.WriteLine("Please select a valid answer");
                    j = 0;
               
                }
            }

            Console.WriteLine("    A   B   C");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("1 |" + tic[0] +"|" + tic[1] + "|"  + tic[2] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("2 |" + tic[3] + "|" + tic[4] + "|" + tic[5] + "|");
                    Console.WriteLine("  +---+---+---+");
                    Console.WriteLine("3 |" + tic[6] + "|" + tic[7] + "|" + tic[8] + "|");
                    Console.WriteLine("  +---+---+---+");

            Console.WriteLine("Player O where do you want to move?");
            for (int j = 0; j < 2; j++)
            {
                String t2 = Console.ReadLine();
                if (t2 == "1a")
                {
                    tic[0] = " o ";
                }
                if (t2 == "2a")
                {
                    tic[3] = " o ";
                }
                if (t2 == "3a")
                {
                    tic[6] = " o ";
                }
                if (t2 == "1b")
                {
                    tic[1] = " o ";
                }
                if (t2 == "2b")
                {
                    tic[4] = " o ";
                }
                if (t2 == "3b")
                {
                    tic[7] = " o ";
                }
                if (t2 == "1c")
                {
                    tic[2] = " o ";
                }
                if (t2 == "2c")
                {
                    tic[5] = " o ";
                }
                if (t2 == "3c")
                {
                    tic[8] = " o ";
                }
                else
                {
                    Console.WriteLine("Please select a valid answer");
                }
            }
            Console.WriteLine("    A   B   C");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("1 |" + tic[0] + "|" + tic[1] + "|" + tic[2] + "|");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("2 |" + tic[3] + "|" + tic[4] + "|" + tic[5] + "|");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("3 |" + tic[6] + "|" + tic[7] + "|" + tic[8] + "|");
            Console.WriteLine("  +---+---+---+");

            String t3 = Console.ReadLine();
            if (t3 == "1a")
            {
                tic[0] = " x ";
            }
            if (t3 == "2a")
            {
                tic[3] = " x ";
            }
            if (t3 == "3a")
            {
                tic[6] = " x ";
            }
            if (t3 == "1b")
            {
                tic[1] = " x ";
            }
            if (t3 == "2b")
            {
                tic[4] = " x ";
            }
            if (t3 == "3b")
            {
                tic[7] = " x ";
            }
            if (t3 == "1c")
            {
                tic[2] = " x ";
            }
            if (t3 == "2c")
            {
                tic[5] = " x ";
            }
            if (t3 == "3c")
            {
                tic[8] = " x ";
            }
            else
            {
                Console.WriteLine("Please select a valid answer");
            }

            Console.WriteLine("    A   B   C");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("1 |" + tic[0] + "|" + tic[1] + "|" + tic[2] + "|");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("2 |" + tic[3] + "|" + tic[4] + "|" + tic[5] + "|");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("3 |" + tic[6] + "|" + tic[7] + "|" + tic[8] + "|");
            Console.WriteLine("  +---+---+---+");

            String t4 = Console.ReadLine();
            if (t4 == "1a")
            {
                tic[0] = " o ";
            }
            if (t4 == "2a")
            {
                tic[3] = " o ";
            }
            if (t4 == "3a")
            {
                tic[6] = " o ";
            }
            if (t4 == "1b")
            {
                tic[1] = " o ";
            }
            if (t4 == "2b")
            {
                tic[4] = " o ";
            }
            if (t4 == "3b")
            {
                tic[7] = " o ";
            }
            if (t4 == "1c")
            {
                tic[2] = " o ";
            }
            if (t4 == "2c")
            {
                tic[5] = " o ";
            }
            if (t4 == "3c")
            {
                tic[8] = " o ";
            }
            else
            {
                Console.WriteLine("Please select a valid answer");
            }

            Console.WriteLine("    A   B   C");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("1 |" + tic[0] + "|" + tic[1] + "|" + tic[2] + "|");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("2 |" + tic[3] + "|" + tic[4] + "|" + tic[5] + "|");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("3 |" + tic[6] + "|" + tic[7] + "|" + tic[8] + "|");
            Console.WriteLine("  +---+---+---+");

            String t5 = Console.ReadLine();
            if (t5 == "1a")
            {
                tic[0] = " x ";
            }
            if (t5 == "2a")
            {
                tic[3] = " x ";
            }
            if (t5 == "3a")
            {
                tic[6] = " x ";
            }
            if (t5 == "1b")
            {
                tic[1] = " x ";
            }
            if (t5 == "2b")
            {
                tic[4] = " x ";
            }
            if (t5 == "3b")
            {
                tic[7] = " x ";
            }
            if (t5 == "1c")
            {
                tic[2] = " x ";
            }
            if (t5 == "2c")
            {
                tic[5] = " x ";
            }
            if (t5 == "3c")
            {
                tic[8] = " x ";
            }
            else
            {

                Console.WriteLine("Please select a valid answer");
            }

            Console.WriteLine("    A   B   C");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("1 |" + tic[0] + "|" + tic[1] + "|" + tic[2] + "|");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("2 |" + tic[3] + "|" + tic[4] + "|" + tic[5] + "|");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("3 |" + tic[6] + "|" + tic[7] + "|" + tic[8] + "|");
            Console.WriteLine("  +---+---+---+");

            String t6 = Console.ReadLine();
            if (t6 == "1a")
            {
                tic[0] = " o ";
            }
            if (t6 == "2a")
            {
                tic[3] = " o ";
            }
            if (t6 == "3a")
            {
                tic[6] = " o ";
            }
            if (t6 == "1b")
            {
                tic[1] = " o ";
            }
            if (t6 == "2b")
            {
                tic[4] = " o ";
            }
            if (t6 == "3b")
            {
                tic[7] = " o ";
            }
            if (t6 == "1c")
            {
                tic[2] = " o ";
            }
            if (t6 == "2c")
            {
                tic[5] = " o ";
            }
            if (t6 == "3c")
            {
                tic[8] = " o ";
            }
            else
            {
                Console.WriteLine("Please select a valid answer");
            }

            Console.WriteLine("    A   B   C");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("1 |" + tic[0] + "|" + tic[1] + "|" + tic[2] + "|");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("2 |" + tic[3] + "|" + tic[4] + "|" + tic[5] + "|");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("3 |" + tic[6] + "|" + tic[7] + "|" + tic[8] + "|");
            Console.WriteLine("  +---+---+---+");

            String t7 = Console.ReadLine();
            if (t7 == "1a")
            {
                tic[0] = " x ";
            }
            if (t7 == "2a")
            {
                tic[3] = " x ";
            }
            if (t7 == "3a")
            {
                tic[6] = " x ";
            }
            if (t7 == "1b")
            {
                tic[1] = " x ";
            }
            if (t7 == "2b")
            {
                tic[4] = " x ";
            }
            if (t7 == "3b")
            {
                tic[7] = " x ";
            }
            if (t7 == "1c")
            {
                tic[2] = " x ";
            }
            if (t7 == "2c")
            {
                tic[5] = " x ";
            }
            if (t7 == "3c")
            {
                tic[8] = " x ";
            }
            else
            {
                Console.WriteLine("Please select a valid answer");
            }

            Console.WriteLine("    A   B   C");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("1 |" + tic[0] + "|" + tic[1] + "|" + tic[2] + "|");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("2 |" + tic[3] + "|" + tic[4] + "|" + tic[5] + "|");
            Console.WriteLine("  +---+---+---+");
            Console.WriteLine("3 |" + tic[6] + "|" + tic[7] + "|" + tic[8] + "|");
            Console.WriteLine("  +---+---+---+");

           
        }
    }
}

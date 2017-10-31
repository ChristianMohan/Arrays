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
            String[] tic = new String[8];

            
            {
                for(int i = 0; i < 8; i++)
                {
                    tic[i] = "   ";
                }

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
                Console.WriteLine("    A   B   C");
                Console.WriteLine("  +---+---+---+");
                Console.WriteLine("1 |" + tic[0] +"|" + tic[1] + "|"  + tic[2] + "|");
                Console.WriteLine("  +---+---+---+");
                Console.WriteLine("2 |" + tic[3] + "|" + tic[4] + "|" + tic[5] + "|");
                Console.WriteLine("  +---+---+---+");
                Console.WriteLine("3 |" + tic[6] + "|" + tic[7] + "|" + tic[8] + "|");
                Console.WriteLine("  +---+---+---+");
            }
        }
    }
}

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
            bool play = true;

            while(play = true)
            {
                playAgain:;
                Console.WriteLine("Welcome to Tic Tac Toe");
            String[] tic = new String[9];
            
            bool check = false;
            for (int i = 0; i < 9; i++)
                {
                    tic[i] = "   ";
                }



            //TURN 1
            String t1 = "";
                String t2 = "";
                String t3 = "";
            String t4 = "";
            String t5 = "";
                String t6 = "";
            String t7 = "";
            String t8 = "";
            String t9 = "";
                String Answer = "";
                Console.WriteLine("Player X, wwhare do you want to move?");
            while (check == false)
            {
                check = true;
                t1 = Console.ReadLine();
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
                else if(t1 != "1a" && t1 != "2a" && t1 != "3a" && t1 != "1b" && t1 != "2b" && t1 != "3b" && t1 != "1c" && t1 != "2c" && t1 != "3c")
                {
                    Console.WriteLine("Please select a valid answer");
                    check = false;
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



                if (tic[0] == " x " && tic[3] == " x " && tic[6] == " x " || tic[0] == " x " && tic[1] == " x " && tic[2] == " x " || tic[0] == " x " && tic[4] == " x " && tic[8] == " x " || tic[2] == " x " && tic[4] == " x " && tic[6] == " x " || tic[2] == " x " && tic[5] == " x " && tic[8] == " x " || tic[6] == " x " && tic[7] == " x " && tic[8] == " x " || tic[3] == " x " && tic[4] == " x " && tic[5] == " x " || tic[1] == " x " && tic[4] == " x " && tic[7] == " x ")
                {
                    Console.WriteLine("Player X wins!");

                    while (play == true)
                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }
                else if (tic[0] == " o " && tic[3] == " o " && tic[6] == " o " || tic[0] == " o " && tic[1] == " o " && tic[2] == " o " || tic[0] == " o " && tic[4] == " o " && tic[8] == " o " || tic[2] == " o " && tic[4] == " o " && tic[6] == " o " || tic[2] == " o " && tic[5] == " o " && tic[8] == " o " || tic[6] == " o " && tic[7] == " o " && tic[8] == " o " || tic[3] == " o " && tic[4] == " o " && tic[5] == " o " || tic[1] == " o " && tic[4] == " o " && tic[7] == " o ")
                {
                    Console.WriteLine("Player O wins!");

                    while (play == true)

                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }

                //TURN 2

                Console.WriteLine("Player O where do you want to move?");
            check = false;
            while (check == false)
            {
                
                t2 = Console.ReadLine();
                if (t2 != t1)
                {
                    check = true;
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
                    else if (t2 != "1a" && t2 != "2a" && t2 != "3a" && t2 != "1b" && t2 != "2b" && t2 != "3b" && t2 != "1c" && t2 != "2c" && t2 != "3c")
                    {
                        Console.WriteLine("Please select a valid answer");
                        check = false;
                    }
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




                if (tic[0] == " x " && tic[3] == " x " && tic[6] == " x " || tic[0] == " x " && tic[1] == " x " && tic[2] == " x " || tic[0] == " x " && tic[4] == " x " && tic[8] == " x " || tic[2] == " x " && tic[4] == " x " && tic[6] == " x " || tic[2] == " x " && tic[5] == " x " && tic[8] == " x " || tic[6] == " x " && tic[7] == " x " && tic[8] == " x " || tic[3] == " x " && tic[4] == " x " && tic[5] == " x " || tic[1] == " x " && tic[4] == " x " && tic[7] == " x ")
                {
                    Console.WriteLine("Player X wins!");

                    while (play == true)
                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }
                else if (tic[0] == " o " && tic[3] == " o " && tic[6] == " o " || tic[0] == " o " && tic[1] == " o " && tic[2] == " o " || tic[0] == " o " && tic[4] == " o " && tic[8] == " o " || tic[2] == " o " && tic[4] == " o " && tic[6] == " o " || tic[2] == " o " && tic[5] == " o " && tic[8] == " o " || tic[6] == " o " && tic[7] == " o " && tic[8] == " o " || tic[3] == " o " && tic[4] == " o " && tic[5] == " o " || tic[1] == " o " && tic[4] == " o " && tic[7] == " o ")
                {
                    Console.WriteLine("Player O wins!");

                    while (play == true)

                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }

                //TURN 3
                Console.WriteLine("Player X, wwhare do you want to move?");
            check = false;
            while (check == false)
            {
                
                t3 = Console.ReadLine();
                if (t3 != t1 && t3 != t2)
                {
                    check = true;
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
                    else if (t3 != "1a" && t3 != "2a" && t3 != "3a" && t3 != "1b" && t3 != "2b" && t3 != "3b" && t3 != "1c" && t3 != "2c" && t3 != "3c")
                    {
                        Console.WriteLine("Please select a valid answer");
                        check = false;
                    }
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






                if (tic[0] == " x " && tic[3] == " x " && tic[6] == " x " || tic[0] == " x " && tic[1] == " x " && tic[2] == " x " || tic[0] == " x " && tic[4] == " x " && tic[8] == " x " || tic[2] == " x " && tic[4] == " x " && tic[6] == " x " || tic[2] == " x " && tic[5] == " x " && tic[8] == " x " || tic[6] == " x " && tic[7] == " x " && tic[8] == " x " || tic[3] == " x " && tic[4] == " x " && tic[5] == " x " || tic[1] == " x " && tic[4] == " x " && tic[7] == " x ")
                {
                    Console.WriteLine("Player X wins!");

                    while (play == true)
                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }
                else if (tic[0] == " o " && tic[3] == " o " && tic[6] == " o " || tic[0] == " o " && tic[1] == " o " && tic[2] == " o " || tic[0] == " o " && tic[4] == " o " && tic[8] == " o " || tic[2] == " o " && tic[4] == " o " && tic[6] == " o " || tic[2] == " o " && tic[5] == " o " && tic[8] == " o " || tic[6] == " o " && tic[7] == " o " && tic[8] == " o " || tic[3] == " o " && tic[4] == " o " && tic[5] == " o " || tic[1] == " o " && tic[4] == " o " && tic[7] == " o ")
                {
                    Console.WriteLine("Player O wins!");

                    while (play == true)

                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }

                //TURN 4
                Console.WriteLine("Player O where do you want to move?");
            check = false;
            while (check == false)
            {
                
                
                t4 = Console.ReadLine();
                if (t4 != t1 && t4 != t2 && t4 != t3)
                {
                    check = true;
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
                    else if (t4 != "1a" && t4 != "2a" && t4 != "3a" && t4 != "1b" && t4 != "2b" && t4 != "3b" && t4 != "1c" && t4 != "2c" && t4 != "3c")
                    {
                        Console.WriteLine("Please select a valid answer");
                        check = false;
                    }
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





                if (tic[0] == " x " && tic[3] == " x " && tic[6] == " x " || tic[0] == " x " && tic[1] == " x " && tic[2] == " x " || tic[0] == " x " && tic[4] == " x " && tic[8] == " x " || tic[2] == " x " && tic[4] == " x " && tic[6] == " x " || tic[2] == " x " && tic[5] == " x " && tic[8] == " x " || tic[6] == " x " && tic[7] == " x " && tic[8] == " x " || tic[3] == " x " && tic[4] == " x " && tic[5] == " x " || tic[1] == " x " && tic[4] == " x " && tic[7] == " x ")
                {
                    Console.WriteLine("Player X wins!");

                    while (play == true)
                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }
                else if (tic[0] == " o " && tic[3] == " o " && tic[6] == " o " || tic[0] == " o " && tic[1] == " o " && tic[2] == " o " || tic[0] == " o " && tic[4] == " o " && tic[8] == " o " || tic[2] == " o " && tic[4] == " o " && tic[6] == " o " || tic[2] == " o " && tic[5] == " o " && tic[8] == " o " || tic[6] == " o " && tic[7] == " o " && tic[8] == " o " || tic[3] == " o " && tic[4] == " o " && tic[5] == " o " || tic[1] == " o " && tic[4] == " o " && tic[7] == " o ")
                {
                    Console.WriteLine("Player O wins!");

                    while (play == true)

                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }

                //TURN 5
                Console.WriteLine("Player X, wwhare do you want to move?");
            check = false;
            while (check == false)
            {
                
                t5 = Console.ReadLine();
                if (t5 != t1 && t5 != t2 && t5 != t3 && t5 != t4)
                {
                    check = true;
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
                    else if (t5 != "1a" && t5 != "2a" && t5 != "3a" && t5 != "1b" && t5 != "2b" && t5 != "3b" && t5 != "1c" && t5 != "2c" && t5 != "3c")
                    {

                        Console.WriteLine("Please select a valid answer");
                        check = false;
                    }
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




                if (tic[0] == " x " && tic[3] == " x " && tic[6] == " x " || tic[0] == " x " && tic[1] == " x " && tic[2] == " x " || tic[0] == " x " && tic[4] == " x " && tic[8] == " x " || tic[2] == " x " && tic[4] == " x " && tic[6] == " x " || tic[2] == " x " && tic[5] == " x " && tic[8] == " x " || tic[6] == " x " && tic[7] == " x " && tic[8] == " x " || tic[3] == " x " && tic[4] == " x " && tic[5] == " x " || tic[1] == " x " && tic[4] == " x " && tic[7] == " x ")
                {
                    Console.WriteLine("Player X wins!");

                    while (play == true)
                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }
                else if (tic[0] == " o " && tic[3] == " o " && tic[6] == " o " || tic[0] == " o " && tic[1] == " o " && tic[2] == " o " || tic[0] == " o " && tic[4] == " o " && tic[8] == " o " || tic[2] == " o " && tic[4] == " o " && tic[6] == " o " || tic[2] == " o " && tic[5] == " o " && tic[8] == " o " || tic[6] == " o " && tic[7] == " o " && tic[8] == " o " || tic[3] == " o " && tic[4] == " o " && tic[5] == " o " || tic[1] == " o " && tic[4] == " o " && tic[7] == " o ")
                {
                    Console.WriteLine("Player O wins!");

                    while (play == true)

                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }

                //TURN 6
                Console.WriteLine("Player O where do you want to move?");
            check = false;
            while (check == false)
            {
                
                t6 = Console.ReadLine();
            if(t6 != t1 && t6 != t2 && t6 != t3 && t6 != t4 && t6 != t5)
              { 
                check = true;
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
                else if (t6 != "1a" && t6 != "2a" && t6 != "3a" && t6 != "1b" && t6 != "2b" && t6 != "3b" && t6 != "1c" && t6 != "2c" && t6 != "3c")
                {
                    Console.WriteLine("Please select a valid answer");
                    check = false;
                }
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




                if (tic[0] == " x " && tic[3] == " x " && tic[6] == " x " || tic[0] == " x " && tic[1] == " x " && tic[2] == " x " || tic[0] == " x " && tic[4] == " x " && tic[8] == " x " || tic[2] == " x " && tic[4] == " x " && tic[6] == " x " || tic[2] == " x " && tic[5] == " x " && tic[8] == " x " || tic[6] == " x " && tic[7] == " x " && tic[8] == " x " || tic[3] == " x " && tic[4] == " x " && tic[5] == " x " || tic[1] == " x " && tic[4] == " x " && tic[7] == " x ")
                {
                    Console.WriteLine("Player X wins!");

                    while (play == true)
                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }
                else if (tic[0] == " o " && tic[3] == " o " && tic[6] == " o " || tic[0] == " o " && tic[1] == " o " && tic[2] == " o " || tic[0] == " o " && tic[4] == " o " && tic[8] == " o " || tic[2] == " o " && tic[4] == " o " && tic[6] == " o " || tic[2] == " o " && tic[5] == " o " && tic[8] == " o " || tic[6] == " o " && tic[7] == " o " && tic[8] == " o " || tic[3] == " o " && tic[4] == " o " && tic[5] == " o " || tic[1] == " o " && tic[4] == " o " && tic[7] == " o ")
                {
                    Console.WriteLine("Player O wins!");

                    while (play == true)

                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }

                //TURN 7
                Console.WriteLine("Player X, wwhare do you want to move?");
            check = false;
            while (check == false)
            {
                
                t7 = Console.ReadLine();
             if (t7 != t1 && t7 != t2 && t7 != t3 && t7 != t4 && t7 != t5 && t7 != t6)
              { 
                check = true;
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
                else if (t7 != "1a" && t7 != "2a" && t7 != "3a" && t7 != "1b" && t7 != "2b" && t7 != "3b" && t7 != "1c" && t7 != "2c" && t7 != "3c")
                {
                    Console.WriteLine("Please select a valid answer");
                    check = false;
                }
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



                if (tic[0] == " x " && tic[3] == " x " && tic[6] == " x " || tic[0] == " x " && tic[1] == " x " && tic[2] == " x " || tic[0] == " x " && tic[4] == " x " && tic[8] == " x " || tic[2] == " x " && tic[4] == " x " && tic[6] == " x " || tic[2] == " x " && tic[5] == " x " && tic[8] == " x " || tic[6] == " x " && tic[7] == " x " && tic[8] == " x " || tic[3] == " x " && tic[4] == " x " && tic[5] == " x " || tic[1] == " x " && tic[4] == " x " && tic[7] == " x ")
                {
                    Console.WriteLine("Player X wins!");

                    while (play == true)
                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }
                else if (tic[0] == " o " && tic[3] == " o " && tic[6] == " o " || tic[0] == " o " && tic[1] == " o " && tic[2] == " o " || tic[0] == " o " && tic[4] == " o " && tic[8] == " o " || tic[2] == " o " && tic[4] == " o " && tic[6] == " o " || tic[2] == " o " && tic[5] == " o " && tic[8] == " o " || tic[6] == " o " && tic[7] == " o " && tic[8] == " o " || tic[3] == " o " && tic[4] == " o " && tic[5] == " o " || tic[1] == " o " && tic[4] == " o " && tic[7] == " o ")
                {
                    Console.WriteLine("Player O wins!");

                    while (play == true)

                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }



                //TURN 8

                Console.WriteLine("Player O where do you want to move?");
            check = false;
            while (check == false)
            {

                t8 = Console.ReadLine();
                if (t8 != t1 && t8 != t2 && t8 != t3 && t8 != t4 && t8 != t5 && t8 != t6 && t8 != t7)
                {
                    check = true;
                    if (t8 == "1a")
                    {
                        tic[0] = " o ";
                    }
                    if (t8 == "2a")
                    {
                        tic[3] = " o ";
                    }
                    if (t8 == "3a")
                    {
                        tic[6] = " o ";
                    }
                    if (t8 == "1b")
                    {
                        tic[1] = " o ";
                    }
                    if (t8 == "2b")
                    {
                        tic[4] = " o ";
                    }
                    if (t8 == "3b")
                    {
                        tic[7] = " o ";
                    }
                    if (t8 == "1c")
                    {
                        tic[2] = " o ";
                    }
                    if (t8 == "2c")
                    {
                        tic[5] = " o ";
                    }
                    if (t8 == "3c")
                    {
                        tic[8] = " o ";
                    }
                    else if (t8 != "1a" && t8 != "2a" && t8 != "3a" && t8 != "1b" && t8 != "2b" && t8 != "3b" && t8 != "1c" && t8 != "2c" && t8 != "3c")
                    {
                        Console.WriteLine("Please select a valid answer");
                        check = false;
                        
                    }
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




                if (tic[0] == " x " && tic[3] == " x " && tic[6] == " x " || tic[0] == " x " && tic[1] == " x " && tic[2] == " x " || tic[0] == " x " && tic[4] == " x " && tic[7] == " x " || tic[2] == " x " && tic[4] == " x " && tic[6] == " x " || tic[2] == " x " && tic[5] == " x " && tic[8] == " x " || tic[6] == " x " && tic[7] == " x " && tic[8] == " x ")
                {
                    Console.WriteLine("Player X wins!");

                    while (play == true)
                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }
                else if (tic[0] == " o " && tic[3] == " o " && tic[6] == " o " || tic[0] == " o " && tic[1] == " o " && tic[2] == " o " || tic[0] == " o " && tic[4] == " o " && tic[7] == " o " || tic[2] == " o " && tic[4] == " o " && tic[6] == " o " || tic[2] == " o " && tic[5] == " o " && tic[8] == " o " || tic[6] == " o " && tic[7] == " o " && tic[8] == " o ")
                {
                    Console.WriteLine("Player O wins!");

                    while (play == true)

                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }


                //TURN 9

                Console.WriteLine("Player X, wwhare do you want to move?");
            check = false;
            while (check == false)
            {

                t9 = Console.ReadLine();
                if (t9 != t1 && t9 != t2 && t9 != t3 && t9 != t4 && t9 != t5 && t9 != t6 && t9 != t7 && t9 != t8)
                {
                    check = true;
                    if (t9 == "1a")
                    {
                        tic[0] = " x ";
                    }
                    if (t9 == "2a")
                    {
                        tic[3] = " x ";
                    }
                    if (t9 == "3a")
                    {
                        tic[6] = " x ";
                    }
                    if (t9 == "1b")
                    {
                        tic[1] = " x ";
                    }
                    if (t9 == "2b")
                    {
                        tic[4] = " x ";
                    }
                    if (t9 == "3b")
                    {
                        tic[7] = " x ";
                    }
                    if (t9 == "1c")
                    {
                        tic[2] = " x ";
                    }
                    if (t9 == "2c")
                    {
                        tic[5] = " x ";
                    }
                    if (t9 == "3c")
                    {
                        tic[8] = " x ";
                    }
                    else if (t9 != "1a" && t9 != "2a" && t9 != "3a" && t9 != "1b" && t9 != "2b" && t9 != "3b" && t9 != "1c" && t9 != "2c" && t9 != "3c")
                    {
                        Console.WriteLine("Please select a valid answer");
                        check = false;
                    }
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


                if (tic[0] == " x " && tic[3] == " x " && tic[6] == " x " || tic[0] == " x " && tic[1] == " x " && tic[2] == " x " || tic[0] == " x " && tic[4] == " x " && tic[8] == " x " || tic[2] == " x " && tic[4] == " x " && tic[6] == " x " || tic[2] == " x " && tic[5] == " x " && tic[8] == " x " || tic[6] == " x " && tic[7] == " x " && tic[8] == " x " || tic[3] == " x " && tic[4] == " x " && tic[5] == " x " || tic[1] == " x " && tic[4] == " x " && tic[7] == " x ")
                {
                    Console.WriteLine("Player X wins!");

                    while (play == true)
                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }
                else if (tic[0] == " o " && tic[3] == " o " && tic[6] == " o " || tic[0] == " o " && tic[1] == " o " && tic[2] == " o " || tic[0] == " o " && tic[4] == " o " && tic[8] == " o " || tic[2] == " o " && tic[4] == " o " && tic[6] == " o " || tic[2] == " o " && tic[5] == " o " && tic[8] == " o " || tic[6] == " o " && tic[7] == " o " && tic[8] == " o " || tic[3] == " o " && tic[4] == " o " && tic[5] == " o " || tic[1] == " o " && tic[4] == " o " && tic[7] == " o ")
                {
                    Console.WriteLine("Player O wins!");

                    while (play == true)

                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("It is a Draw!");

                    while (play == true)

                    {
                        Console.WriteLine("Would you like to play again?");
                        Answer = Console.ReadLine();
                        if (Answer == "yes" || Answer == "Yes")
                        {
                            goto playAgain;
                        }
                        else if (Answer == "no" || Answer == "No")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please select Yes or No");
                        }
                    }

                }
            }

        }
    }
}

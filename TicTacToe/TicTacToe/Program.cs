using System;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;

        //flag to check winner:  1=winner  -1=draw  0=game not finished
        static int flag = 0;

        static void Main(string[] args)
        {


            do
            {
                Console.Clear();
                Console.WriteLine("Player 1:X & Player 2:O" + Environment.NewLine);
                Console.WriteLine("");
                //Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("");
                //Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry.  The row {0} is already marked by {1}", choice, arr[choice]);
                    Console.WriteLine("");
                    Console.WriteLine("Pleasre wait 3 seconds for board to load again.  Let's hope your PC isn't slow....");
                    Thread.Sleep(2222);
                }
                flag = CheckWinner();
            } while (flag != 1 && flag != -1); //will execute this loop at least once

            Console.Clear();
            Board();
            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won the game", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();

        }

        private static void Board()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine(" {0} | {1} | {2} ", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine(" {0} | {1} | {2} ", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine(" {0} | {1} | {2} ", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |     ");
        }

        private static int CheckWinner()
        {
            #region Horizontal Winning Condition
            //1st Row
            if(arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //2nd Row
            if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //3rd Row
            if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion

            #region Vertical Winning Condition
            //1st Column
            if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //1st Row
            if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //1st Row
            if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion

            #region Diagnoal Winning Condition
            //top left to bottom right
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            //top right to bottom left
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion

            #region Draw Condition
            //All cells full but no winner
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;
            }
        }
    
    }
}

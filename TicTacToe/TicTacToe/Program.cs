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

            do
            {
                Console.Clear();
                Console.WriteLine("Player 1:X & Player 2:O" + Environment.NewLine);
                Console.WriteLine("");
                //Console.WriteLine("\n");
                if (player %2 == 0)
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

                if(arr[choice] !='X' && arr[choice] != 'O')
                {
                    if (player %2 == 0)
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
                flag = CheckWin();
            }
                while (flag != 1 && flag != -1) ;
            Console.Clear();
        }
    }
}

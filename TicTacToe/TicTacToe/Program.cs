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
                //Console.WriteLine("\n");
            }
            Console.Clear();
        }
    }
}

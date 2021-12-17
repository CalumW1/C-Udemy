using System;

namespace TicTacToe
{
    class Program
    {
        static string[,] board = 
            { 
                {"1", "2", "3" },
                {"4", "5", "6" },
                {"7", "8", "9" }
            };
        static void Main(string[] args)
        {
            createField();
            playersTurns();

        }


        public static void createField()
        {
            Console.WriteLine("{0} | {1} | {2}", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("--------------");
            Console.WriteLine("{0} | {1} | {2}", board[1,0], board[1, 1], board[1, 2]);
            Console.WriteLine("--------------");
            Console.WriteLine("{0} | {1} | {2}", board[2, 0], board[2, 1], board[2, 2]);
        }

        public static void playersTurns()
        {
            bool playersATurn = true; 

            if(playersATurn == true)
            {
                Console.WriteLine("Player 1: Choose your field: ");
                Console.ReadLine();
                playersATurn = false;
            }

            if(playersATurn == false)
            {
                Console.WriteLine("Player 2: Choose your field: ");
                Console.ReadLine();
                playersATurn = true;
            }
        }





    }
}

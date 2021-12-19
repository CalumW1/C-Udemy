using System;

namespace TicTacToe
{
    class Program
    {
        // Create 2d array for the game board.
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
        // render the board. 
        public static void createField()
        {
            Console.WriteLine("{0} | {1} | {2}", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("--------------");
            Console.WriteLine("{0} | {1} | {2}", board[1,0], board[1, 1], board[1, 2]);
            Console.WriteLine("--------------");
            Console.WriteLine("{0} | {1} | {2}", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine();
        }

        // function to handle the turn of players 
        public static void playersTurns()
        {
            int counter = 0;
            bool playersATurn = true; 

            while (counter < 9)
            {
                if(playersATurn == true)
                {
                    Console.WriteLine("Player 1: Choose your field: ");
                    string input = Console.ReadLine();
                    insertCharacter("x", input);
                    playersATurn = false;
                    counter++;
                }
                else
                {
                    Console.WriteLine("Player 2: Choose your field: ");
                    string input = Console.ReadLine();
                    insertCharacter("O", input);
                    playersATurn = true;
                    counter++;
                }
            }
        }

        // Function to change the numbers on the board to X or O.  
        public static void insertCharacter(string userInput, string Location)
        {
            if(Location == "1" || Location == "2" || Location == "3")
            {
                board[0, int.Parse(Location) - 1] = userInput;
                Console.WriteLine();
                Console.WriteLine();
                createField();
                Console.WriteLine();
            } 
        }





    }
}

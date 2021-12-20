using System;

namespace TicTacToe
{
    class Program
    {
        static bool playersATurn = true;


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

            while (counter < 9)
            {
                if(playersATurn == true)
                {
                    Console.WriteLine("Player 1: Choose your field: ");
                    string input = Console.ReadLine();
                    playersATurn = false;
                    insertCharacter("x", input);
                    counter++;
                }
                else
                {
                    Console.WriteLine("Player 2: Choose your field: ");
                    string input = Console.ReadLine();
                    playersATurn = true;
                    insertCharacter("O", input);
                    counter++;
                }
            }
        }

        // Function to change the numbers on the board to X or O.  
        public static void insertCharacter(string userInput, string Location)
        {
            if(Location == "1" || Location == "2" || Location == "3")
            {
                // check if the board has a O or X in it; 
                if(board[0, int.Parse(Location) - 1] == "x" || board[0, int.Parse(Location) - 1] == "O")
                {
                    // if the input is X set playersATurn True else False; 
                    if(userInput == "x")
                    {
                        Console.WriteLine("this position is taken");
                        playersATurn = true;
                    }
                    else
                    {
                        Console.WriteLine("this position is taken");
                        playersATurn = false;
                    }   
                }
                // if the square is empty then insert character. 
                else
                {
                    board[0, int.Parse(Location) - 1] = userInput;
                    Console.WriteLine();
                    Console.WriteLine();
                    createField();
                    Console.WriteLine();
                }
                
            } 
            else if(Location == "4" || Location == "5" || Location == "6")
            {
                if(board[1, int.Parse(Location) - 4] == "x" || board[1, int.Parse(Location)] == "O")
                {
                    if(userInput == "x")
                    {
                        Console.WriteLine("this ");
                    }
                    else
                    {

                    }
                }
                board[1, int.Parse(Location) - 4] = userInput;
                Console.WriteLine();
                Console.WriteLine();
                createField();
                Console.WriteLine();
            }
            else if (Location == "7" || Location == "8" || Location == "9")
            {
                board[2, int.Parse(Location) - 7] = userInput;
                Console.WriteLine();
                Console.WriteLine();
                createField();
                Console.WriteLine();
            }
        }

        




    }
}

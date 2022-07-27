using System;

namespace TicTacToe_App
{
    internal class Program
    {
        static char[,] board =
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };

        static bool isAWinner = false;
        static bool playAgain = false;

        const char PlayerOneChar = 'X';
        const char PlayerTwoChar = 'O';

        // player 1 = x
        // player 2 = o

        static void Main(string[] args)
        {
            DisplayBoard();

            int iterator = 0;
            int currentPlayer = 0;

            do
            {
                while (!isAWinner)
                {
                    // determine the current player
                    if (iterator % 2 == 0)
                        currentPlayer = 1;
                    else
                        currentPlayer = 2;

                    Console.Write("\nPlayer {0}, select a position: ", currentPlayer);
                    int position = Int32.Parse(Console.ReadLine());

                    UpdateBoard(position, currentPlayer);

                    DisplayBoard();
                    
                    isAWinner = CheckForAWinner(currentPlayer);

                    iterator++;
                }

                Console.WriteLine("\nCongratulations Player {0} is the winner!", currentPlayer);

                Console.Write("\nDo you want to play again? (y/n): ");
                string input = Console.ReadLine();

                if (input.Equals("y"))
                {
                    ResetBoard();
                    isAWinner = false;
                    iterator = 0;
                    DisplayBoard();
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            while (playAgain);


        }

        static void DisplayBoard()
        {
            Console.Clear();

            Console.WriteLine("TIC TAC TOE");
            Console.WriteLine("------------");
            Console.WriteLine("Player 1 = X");
            Console.WriteLine("Player 2 = O");
            Console.WriteLine("------------\n");

            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("     |     |     ");
        }

        static void UpdateBoard(int position, int player)
        {
            char playerMove;

            // determine the character to use
            if (player == 1)
                playerMove = PlayerOneChar;
            else if (player == 2)
                playerMove = PlayerTwoChar;
            else
                throw new Exception("Invalid player");

            // update the board
            switch (position)
            {
                case 1:
                    board[0, 0] = playerMove;
                    break;
                case 2:
                    board[0, 1] = playerMove;
                    break;
                case 3:
                    board[0, 2] = playerMove;
                    break;
                case 4:
                    board[1, 0] = playerMove;
                    break;
                case 5:
                    board[1, 1] = playerMove;
                    break;
                case 6:
                    board[1, 2] = playerMove;
                    break;
                case 7:
                    board[2, 0] = playerMove;
                    break;
                case 8:
                    board[2, 1] = playerMove;
                    break;
                case 9:
                    board[2, 2] = playerMove;
                    break;
                default:
                    Console.WriteLine("Your have not entered a valid position.");
                    break;
            }
        }

        static bool CheckForAWinner(int player)
        {
            char checkChar = ' ';

            // determine the char to check for
            if (player == 1)
            {
                checkChar = PlayerOneChar;
            }
            else if (player == 2)
            {
                checkChar = PlayerTwoChar;
            }
            else
            {
                throw new Exception("Invalid player");
            }

            // horizontal rows for a winner
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == checkChar && board[i, 1] == checkChar && board[i, 2] == checkChar)
                {
                    return true;
                }
            }

            // check vertical columns for a winner
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == checkChar && board[1, i] == checkChar && board[2, i] == checkChar)
                {
                    return true;
                }
            }

            // check top left to bottom right diagonal for a winner
            if (board[0, 0] == checkChar && board[1, 1] == checkChar && board[2, 2] == checkChar)
            {
                return true;
            }// check top right to bottom left diagonal for a winner
            else if (board[2, 0] == checkChar && board[1, 1] == checkChar && board[0, 2] == checkChar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void ResetBoard()
        {
            board[0, 0] = '1';
            board[0, 1] = '2';
            board[0, 2] = '3';
            board[1, 0] = '4';
            board[1, 1] = '5';
            board[1, 2] = '6';
            board[2, 0] = '7';
            board[2, 1] = '8';
            board[2, 2] = '9';
        }
    }
}

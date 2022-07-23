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

        // player 1 = x
        // player 2 = o

        static void Main(string[] args)
        {
            DisplayBoard();

            int iterator = 0;
            int currentPlayer = 0;

            while (!isAWinner)
            {
                if (iterator % 2 == 0)
                    currentPlayer = 1;
                else
                    currentPlayer = 2;

                Console.Write("\nPlayer {0}, select a position: ", currentPlayer);
                int position = Int32.Parse(Console.ReadLine());

                UpdateBoard(position, currentPlayer);

                DisplayBoard();

                iterator++;

                isAWinner = CheckForAWinner(currentPlayer);
            }

            Console.WriteLine("Congratulations Player {0} is the winner!", currentPlayer);
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

            if (player == 1)
                playerMove = 'X';
            else if (player == 2)
                playerMove = 'O';
            else
                throw new Exception("Invalid player");

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
            if (player == 1)
            {
                if (board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X')
                    return true;
                else if (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X')
                    return true;
                else if (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X')
                    return true;
                else if (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X')
                    return true;
                else if (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X')
                    return true;
                else if (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X')
                    return true;
                else if (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X')
                    return true;
                else if (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X')
                    return true;
                else
                    return false;
            }
            else if (player == 2)
            {
                if (board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O')
                    return true;
                else if (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O')
                    return true;
                else if (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O')
                    return true;
                else if (board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O')
                    return true;
                else if (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O')
                    return true;
                else if (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O')
                    return true;
                else if (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O')
                    return true;
                else if (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O')
                    return true;
                else
                    return false;
            }

            return false;
        }
    }
}

using System;

namespace TicTacToe
{
    class Program
    {
        static char[] board = new char[9];
        static char playerSymbol;
        static char botSymbol;
        static char currentPlayer;

        static void Main(string[] args)
        {
            InitializeBoard();
            ChooseSymbol();
            PlayGame();
        }

        static void InitializeBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = ' ';
            }
        }

        static void ChooseSymbol()
        {
            Console.Clear();
            Console.WriteLine("Choose your symbol ('X' or 'O'):");
            char symbol = char.ToUpper(Console.ReadKey().KeyChar);

            if (symbol == 'X')
            {
                playerSymbol = 'X';
                botSymbol = 'O';
            }
            else if (symbol == 'O')
            {
                playerSymbol = 'O';
                botSymbol = 'X';
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid symbol! 'X' is assigned by default.");
                playerSymbol = 'X';
                botSymbol = 'O';
            }

            currentPlayer = playerSymbol;
        }

        static void DrawBoard()
        {
            Console.WriteLine("-------------");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    int position = i * 3 + j;
                    Console.Write(board[position] + " | ");
                }
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
        }

        static void PlayGame()
        {
            bool gameEnded = false;
            int moves = 0;

            while (!gameEnded && moves < 9)
            {
                if (currentPlayer == playerSymbol)
                {
                    Console.Clear();
                    Console.WriteLine("Player's turn (" + currentPlayer + "):");
                    DrawBoard();
                    Console.Write("Enter a number from 1 to 9: ");
                    int position = int.Parse(Console.ReadLine()) - 1;

                    if (IsValidMove(position))
                    {
                        MakeMove(position);
                        moves++;

                        if (CheckForWin())
                        {
                            gameEnded = true;
                            Console.Clear();
                            Console.WriteLine("Player wins!");
                        }

                        currentPlayer = botSymbol;
                    }
                    else
                    {
                        Console.WriteLine("Invalid move! Try again.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Bot's turn (" + currentPlayer + "):");
                    Random random = new Random();

                    int position;

                    do
                    {
                        position = random.Next(0, 9);
                    }
                    while (!IsValidMove(position));

                    MakeMove(position);
                    moves++;

                    if (CheckForWin())
                    {
                        gameEnded = true;
                        Console.Clear();
                        Console.WriteLine("Bot wins!");
                    }

                    currentPlayer = playerSymbol;
                }
            }

            if (!gameEnded)
            {
                Console.Clear();
                Console.WriteLine("It's a tie!");
            }

            DrawBoard();
            Console.WriteLine("Game Over");
        }

        static bool IsValidMove(int position)
        {
            if (position < 0 || position >= 9)
            {
                return false;
            }

            if (board[position] != ' ')
            {
                return false;
            }

            return true;
        }

        static void MakeMove(int position)
        {
            board[position] = currentPlayer;
        }

        static bool CheckForWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i * 3] == currentPlayer && board[i * 3 + 1] == currentPlayer && board[i * 3 + 2] == currentPlayer)
                {
                    return true;
                }
            }
            for (int j = 0; j < 3; j++)
            {
                if (board[j] == currentPlayer && board[j + 3] == currentPlayer && board[j + 6] == currentPlayer)
                {
                    return true;
                }
            }
            if (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer)
            {
                return true;
            }

            if (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer)
            {
                return true;
            }

            return false;
        }
    }
}

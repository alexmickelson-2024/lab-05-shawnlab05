using System;
using System.Runtime.CompilerServices;
using static System.Console;

namespace MainProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int MAX_TURNS = 9;

            WriteLine("\n----------------------------------");
            WriteLine("Welcome to tic-tac-toe");
            WriteLine("----------------------------------");
            WriteLine("Players will take turns choosing an unoccupied cell.");
            WriteLine("The first player to get 3 in a row (or column or diagonal) wins!\n");

            char[] board = new char[9] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };

            // will hold the winning player when there is one
            int winner = 0;

            for (int turn = 0; turn < MAX_TURNS; turn++)
            {
                // player X on even turns, player O on odd turns
                char currentPlayer = turn % 2 == 0 ? 'X' : 'O';
                WriteLine($"currentPlayer={currentPlayer}; turn={turn}");
                WriteLine("Current Board: ");
                DisplayBoard(board);
                MakeMove(currentPlayer, board);
                if (HasWinner(board))
                {
                    winner = currentPlayer;
                    break;
                }
            }
            DisplayBoard(board);

            // print the game outcome
            if (winner == 'X')
            {
                WriteLine("\n/----------------\\");
                WriteLine($"|     X wins!    |");
                WriteLine("\\----------------/");
            }
            else if (winner == 'O')
            {
                WriteLine("\n/----------------\\");
                WriteLine($"|     O wins!    |");
                WriteLine("\\----------------/");
            }
            else
            {
                WriteLine("Looks like a draw");
            }
        }

        // TODO: write the functions used in main (and any other helper functions you want to use)

       public static void DisplayBoard(char[] board)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{board[i * 3]}|{board[i * 3 + 1]}|{board[i * 3 + 2]}");
                Console.WriteLine("");
            }
        }

       public static int GetMove(string prompt, char[] board)
        {
            Console.Write(prompt);
            string inputAsStr = Console.ReadLine().ToLower();
            if (inputAsStr != "a" || inputAsStr != "b" || inputAsStr != "c" || inputAsStr != "d" || inputAsStr != "e" || inputAsStr != "f" || inputAsStr != "g" || inputAsStr != "h" || inputAsStr != "i")
            {
                return GetMove(prompt, board);
            }
            else
            {
                int index = inputAsStr switch
                {
                    "a" => 0,
                    "b" => 1,
                    "c" => 2,
                    "d" => 3,
                    "e" => 4,
                    "f" => 5,
                    "g" => 6,
                    "h" => 7,
                    "i" => 8
                };
                if (board[index] != 'X' || board[index] != 'O')
                {
                    return index;
                }
                else
                {
                    return GetMove(prompt, board);
                }
            }
        }

        //HasWinner
        /* given the board,
         * returns true if the board has a winner (8 possibilities: horizontal, vertical, or diagonal)
         */
        // hint: just return true if you can find three-in-a-row
        // of any character; consider writing the function 'CellsAreTheSame'
        // described below

       public static bool HasWinner(char[] board)
        {
            if (CellsAreTheSame(board[0], board[1], board[2]))
                return true;

            else if (CellsAreTheSame(board[3], board[4], board[5]))
                return true;

            else if (CellsAreTheSame(board[6], board[7], board[8]))
                return true;

            else if (CellsAreTheSame(board[0], board[3], board[6]))
                return true;

            else if (CellsAreTheSame(board[1], board[4], board[7]))
                return true;

            else if (CellsAreTheSame(board[2], board[5], board[8]))
                return true;

            else if (CellsAreTheSame(board[0], board[4], board[8]))
                return true;

            else if (CellsAreTheSame(board[2], board[4], board[6]))
                return true;

            else
                return false;

        }

       public static bool CellsAreTheSame(char a, char b, char c)
        {
            return a == b && b == c;
            // if (a == b && b == c)
            // {
            //     return true;
            // }
            // else
            // {
            //     return false;
            // }
        }
        //MakeMove
        /* Receive the current player and the board as a parameter.
         * Call GetMove($"Player {currentPlayer}: Where do you want to play?").
         * Update the board at that index with the current player's symbol.
         */

       public static void MakeMove(char currentPlayer, char[] board)
        {
            int index = GetMove(($"Player {currentPlayer}: Where do you want to play?"), board);
            board[index] = currentPlayer;
        }


    }

}

using System;
using System.Collections.Generic;
//Cse-210--Juan Pablo Alliaud(copyrightWarning--May_contain_some_code_inspired_by_the_example)
namespace cse210_tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> board = NewBoard();
            string PlayNow = "X";
            do
            {
                ShowBoard(board);
                int choice = GetMove(PlayNow);
                MakeMove(board, choice, PlayNow);

                PlayNow = NextPlayer(PlayNow);
            }while (!GameOver(board));

            ShowBoard(board);
            Console.WriteLine("Good game. Thanks for playing!");
        }

        static List<string> NewBoard()
        {
            List<string> board = new List<string>();

            for (int i = 1; i <= 9; i++)
            {
                board.Add(i.ToString());
            }

            return board;
        }
        static void ShowBoard(List<string> board)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"  {board[0]} |  {board[1]}  | {board[2]}");
            Console.WriteLine("----+-----+----");
            Console.WriteLine($"  {board[3]} |  {board[4]}  | {board[5]}");
            Console.WriteLine("----+-----+----");
            Console.WriteLine($"  {board[6]} |  {board[7]}  | {board[8]}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static bool GameOver(List<string> board)
        {
            bool GameOver = false;

            if (IsWinner(board, "X") || IsWinner(board, "O") || IsTie(board))
            {
                GameOver = true;
            }

            return GameOver;
        }
        static bool IsWinner(List<string> board, string player)
        {


            bool isWinner = false;

            if ((board[0] == player && board[1] == player && board[2] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player)
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player)
                )
            {
                isWinner = true;
            }

            return isWinner; 
        }

        static bool IsTie(List<string> board)
        {
            bool foundDigit = false;

            foreach (string value in board)
            {
                if (char.IsDigit(value[0]))
                {
                    foundDigit = true;
                    break;
                }
            }

            return !foundDigit;
        }

        static string NextPlayer(string PlayNow)
        {
            string nextPlayer = "X";

            if (PlayNow == "X")
            {
                nextPlayer = "O";
            }

            return nextPlayer;
        }

        static int GetMove(string PlayNow)
        {
            Console.Write($"{PlayNow}'s turn to choose a square (1-9): ");
            string Move = Console.ReadLine();

            int choice = int.Parse(Move);
            return choice;
        }
        static void MakeMove(List<string> board, int choice, string PlayNow)
        {
            int index = choice - 1;

            board[index] = PlayNow;
        }
    }
}
using System;
namespace cse210_tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> board = NewBoard();
            ShowBoard(board);






        


        }
        static List<string> NewBoard()
        {
            List<string> board = new List<string>();

            for (int i = 1; i < 10; i = i+1)
            {
                board.Add(i.ToString());
            }

            return board;
        }
        static void ShowBoard(List<string> board)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            // This could be done more elegantly using loops and if statements
            // especially if something besides 3x3 was ever anticipated.
            Console.WriteLine($"  {board[0]} |  {board[1]}  | {board[2]}");
            Console.WriteLine("----+-----+----");
            Console.WriteLine($"  {board[3]} |  {board[4]}  | {board[5]}");
            Console.WriteLine("----+-----+----");
            Console.WriteLine($"  {board[6]} |  {board[7]}  | {board[8]}");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
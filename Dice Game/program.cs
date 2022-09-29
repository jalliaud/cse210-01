using System;

namespace DiceGame
{
    class program
    {
        static void Main(string[]args)
        {
            string PlayAgain = "y";
            while(PlayAgain == "y")
            {
                Director director = new Director();
                director.StartGame();
                Console.WriteLine
                ("-----GAME OVER--------------------------------------------------------------------------------------------");
                Console.WriteLine("Would you like to play again?[y/n]");
                PlayAgain = Console.ReadLine();
                
            }
            Console.WriteLine("_______________Thanks for playing!________________________________________________________________________");
            
        }
    }

}

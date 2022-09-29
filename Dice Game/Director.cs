using System;
using System.Collections.Generic;

namespace DiceGame
{

    public class Director
    {
        List<Die> dice = new List<Die>();
        bool isPlaying = true;
        int score = 0;
        int totalScore = 0;

        public Director()
        {

            for (int i = 0; i < 5; i++)
            {
                Die die = new Die();
                dice.Add(die);
            }
        }

        public void StartGame()
        {
            
            while (isPlaying==true)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
        public void GetInputs()
        {
        Console.WriteLine("Roll dice? [y/n] ");
        string rollDice = Console.ReadLine();
        isPlaying = (rollDice == "y");
        }
        public void DoUpdates()
        {
            if (isPlaying == false)
                return;
            
            for (int i = 0; i < dice.Count; i++)
            {
                Die die = dice[i];
                die.Roll();
                score += die.points;
            }
            totalScore += score;
        }
        public void DoOutputs()
        {
            if (isPlaying == false)
                return;
            
            string values = "";
            for (int i = 0; i < dice.Count; i++)
            {
                Die die = dice[i];
                values += $"{die.value} ";
            }
            
            Console.WriteLine($"You rolled {values}");
            Console.WriteLine($"Your score is: {totalScore}");
            if(score == 0)
                {
                    isPlaying = false;
                }
            score = 0;                
        }
    }
}
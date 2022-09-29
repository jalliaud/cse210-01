using System;
using System.Collections.Generic;

namespace DiceGame
{

    public class Die
    {
        public int value = 0;
        public int points = 0;


        public Die()
        {
        }

        public void Roll()
        {
            Random random = new Random();
            value = random.Next(1, 6);
            
            if (value == 5)
            {
                points = 50;
            }
            else if (value == 1)
            {
                points = 100;
            }
            else
            {
                points = 0;
            }
        }

    }
}
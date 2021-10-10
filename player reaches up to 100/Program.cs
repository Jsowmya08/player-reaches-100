using System;
using System.Collections.Generic;


namespace player_reaches_up_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int player1 = 0;
            int totalTimesDiceRoll = 0;

            while (player1 <= 95)
            {
                int diceRoll = random.Next(1, 7);
                Console.WriteLine("value od dice Roll is {0}", diceRoll);

                var list = new List<string> { "NoPlay", "Ladder", "Snake" };
                Console.WriteLine("options we have 0.Noplay,1.Ladder,2.snake");

                int optionCheck = random.Next(0, 3);
                Console.WriteLine("option we get is : {0}", optionCheck);

                if (list[optionCheck] == "Ladder")
                {
                    player1 = player1 + diceRoll;
                }

                Console.WriteLine("The player postion is : {0}", player1);
                totalTimesDiceRoll++;
            }
            Console.WriteLine("Total no. of times dice rolled is {0}", totalTimesDiceRoll);
        }
    }
}



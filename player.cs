/*

    Project: Hilo Specification
    Name: cse210_02
    Date: 07/05/2022

*/

using System;

namespace cse210_02
{
    public class Player
    {
        Card card = new Card();
        bool isPlaying = true;
        int totalScore = 300;

        public Player()
        {
        }

        // Start the game & finish the game when user has no more points
        // or decide to stop the game
        public void StartGame()
        {
            while (isPlaying && totalScore > 0)
            {
                
                GetInputs();
                DrawCards();
                DoOutputs();
                
            }

            if (!isPlaying)
            {
                Console.WriteLine($"Your total score is {totalScore} points!");
            }
            else if (totalScore <= 0)
            {
                Console.WriteLine("You have no more points!");
                Console.WriteLine("GAME OVER!");
            }

            Console.WriteLine("Thanks for playing!");
        }   

        // Ask the user to draw a card or not
        public void GetInputs()
        {   
            bool chooseCard = true;
            
            do
            {

                Console.WriteLine("Draw a card? [y/n]");
                string drawCard = Console.ReadLine();

                if (drawCard == "y")
                { 
                    isPlaying = true;
                    chooseCard = false;
                } 
                else if (drawCard == "n")
                {
                    isPlaying = false;
                    chooseCard = false;
                }
                else
                {
                    chooseCard = true;
                    Console.WriteLine("Please enter a valid value");
                }
            } while (chooseCard);
        }

        // Draw the two cards numbers
        public void DrawCards()
        {
            if (!isPlaying)
            {
                return;
            }

            card.GetCard1();
            card.GetCard2();
        }

        // Check the guess of the user
        // If user wins = +100pts
        // If user looses = -75pts
        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }

            card.DisplayCardOne();

            Console.Write("Higher or lower? (h/l) ");
            string playerGuess = Console.ReadLine();

            card.DisplayCardTwo();

            bool guess = card.guessNumber(playerGuess);

            if (guess == true)
            {
                totalScore += 100;
            }
            else
            {
                totalScore -= 75;
            }

            Console.WriteLine($"Your score is: {totalScore}\n");
        }

    }

}
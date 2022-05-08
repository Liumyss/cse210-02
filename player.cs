using System;
using System.Collections.Generic;

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

        public void DrawCards()
        {
            if (!isPlaying)
            {
                return;
            }

            card.GetCard1();
            card.GetCard2();
        }

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
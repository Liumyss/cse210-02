using System;
using System.Threading;

namespace cse210_02
{
    public class Player
    {
        Card card = new Card();
        public bool isPlaying = true;
        public int totalScore = 300;
        public int gameNumber = 0;

        public Player()
        {
        }

        // Start the game & finish the game when user has no more points
        // or decide to stop the game
        public void StartGame()
        {
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Welcome to the Hilo Specification Game!");
            Console.WriteLine();
            Thread.Sleep(2000);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------- RULES -------------- ");
            Console.WriteLine("1. You start the game with 300 points.");
            Console.WriteLine("2. Individual cards are represented as a number from 1 to 13.");
            Console.WriteLine("3. You earn 100 points if you guessed the next card correctly.");
            Console.WriteLine("4. You lose 75 points if you guessed it incorrectly.");
            Console.WriteLine("5. If you reach 0 points the game is over.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Thread.Sleep(5000);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GOOD LUCK!");
            Console.ResetColor();
            //Thread.Sleep(2000);

            while (isPlaying && totalScore > 0)
            {
                
                GetInputs();
                DrawCards();
                DoOutputs();
                
            }

            if (!isPlaying)
            {   
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your total score is {totalScore} points!");
            }
            else if (totalScore <= 0)
            {   
                Console.WriteLine();
                Console.WriteLine("You have no more points!");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("GAME OVER!");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine($"You played during {gameNumber} turns.");
            Console.WriteLine("Thanks for playing.");
            Console.WriteLine("See you soon!");
            Console.ResetColor();
        }   

        // Ask the user to draw a card or not
        public void GetInputs()
        {   
            bool chooseCard = true;

            Console.WriteLine();
            Console.WriteLine("-------------- NEW TURN --------------");
            Console.WriteLine();
            Console.Write("Draw a card? [y/n] ");

            do
            {
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

            Console.WriteLine("--------------------------------------");
            Console.Clear();
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

            gameNumber += 1;

            Console.WriteLine($"-------- Turn N°{gameNumber} --------");
            Console.WriteLine();

            card.DisplayCardOne();

            Console.Write("Higher or lower? (h/l) ");

            string playerGuess = "";
            bool invalidAnswer = true;

            do {

                playerGuess = Console.ReadLine();

                if (playerGuess == "h" || playerGuess == "l") 
                {
                    invalidAnswer = false;
                }
                else 
                {
                    Console.WriteLine("Invalid value. Please try again.");
                    invalidAnswer = true;
                }

            } while (invalidAnswer);

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
using System;


namespace cse210_02
{
    class Card{
        public int cardOne = 0;
        public int cardTwo = 0;

        public Card()
        {

        }

        // Get the first card with a number between 1 and 13
        // We know the number of this card before the guessing part
        public void GetCard1(){

            Random random1 = new Random();

            cardOne = random1.Next(1,13);
        }

        // Get the second card with a number between 1 and 13
        // We do not know the number of this card before the guessing part
        public void GetCard2(){

            Random random2 = new Random();
            cardTwo = random2.Next(1,14);

            //A loop to prevent to get the same number as card One
            while (cardOne == cardTwo)
            {
                cardTwo = random2.Next(1,14);
            }
        }

        // Display the first card number
        public void DisplayCardOne()
        {
            Console.WriteLine($"The card is: {cardOne}");
        }

        //Display the second card number
        public void DisplayCardTwo()
        {
            Console.WriteLine($"The next card was: {cardTwo}");
        }

        // Check if user's guess is good or not
        public bool guessNumber(string guess)
        {

          bool isGood = false;

          if (cardOne < cardTwo && guess == "h")
          {
              isGood = true;
          }
          else if (cardOne > cardTwo && guess == "l")
          {
              isGood = true;
          }
          else
          {
              isGood = false;
          }
          
          return isGood;  

        }

    }
}
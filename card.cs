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

            int card1 = random1.Next(1,13);

            cardOne = card1;
        }

        // Get the second card with a number between 1 and 13
        // We do not know the number of this card before the guessing part
        public void GetCard2(){

            Random random2 = new Random();
            int card2 = random2.Next(1,13);

            while(cardOne == card2){
                card2 = random2.Next(1,13);
            }

            cardTwo = card2;
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

          int number1 = cardOne;
          int number2 = cardTwo;

          bool isGood = false;

          if (number1 < number2 && guess == "h")
          {
              isGood = true;
          }
          else if (number1 > number2 && guess == "l")
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
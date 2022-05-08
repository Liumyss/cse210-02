using System;


namespace cse210_02
{
    class Card{
        public int cardOne = 0;
        public int cardTwo = 0;

        public Card()
        {

        }
        public void GetCard1(){

            Random random1 = new Random();

            int card1 = random1.Next(1,13);

            cardOne = card1;
        }

        public void GetCard2(){

            Random random2 = new Random();
            int card2 = random2.Next(1,13);

            while(cardOne == card2){
                card2 = random2.Next(1,13);
            }

            cardTwo = card2;
        }

        public void DisplayCardOne()
        {
            Console.WriteLine($"The card is: {cardOne}");
        }
        
        public void DisplayCardTwo()
        {
            Console.WriteLine($"The next card was: {cardTwo}");
        }

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
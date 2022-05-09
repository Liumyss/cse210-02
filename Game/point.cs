using System;

namespace cse210_02
{
    public class Point
    {   
        public Point()
        {

        }

        // Display a text message according to how many point the user gets
        public void WinnerMessage(int points)
        {
            if (points >= 10000)
            {
                Console.WriteLine("YOU ARE A BOOS AT THIS GAME!!!");
            } 
            else if (points >= 5000)
            {
                Console.WriteLine("WOW! You are so good!");
            }
            else if (points >= 1000)
            {
                Console.WriteLine("How did you do it ? My personal best score has only 3 numbers!");
            }
            else if (points >= 500)
            {
                Console.WriteLine("Don't give up! Next time will be better!");
            }
            else
            {
                Console.WriteLine("You could have done better...");
            }
        }
    }
}
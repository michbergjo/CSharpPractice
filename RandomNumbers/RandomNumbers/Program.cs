using System;


namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 100000;
            int randomNumber;
            int counter = 0;

            Random rand = new Random();

            for(int i = 0; i < 1000; i++)
            {
                randomNumber = rand.Next(0,100001);
                if(randomNumber % 2 != 0)
                {
                    counter++;
                }
                /*if(randomNumber > max)
                  {
                    max = randomNumber;
                   }*/
                //terinary operator max
                max = (randomNumber > max) ? randomNumber : max;

                /*if(randomNumber < min)
                {
                    min = randomNumber;
                }*/
                //terinary operator min
                min = (randomNumber < min) ? randomNumber : min;
            }

            Console.WriteLine("Max Number: {0}", max);
            Console.WriteLine("Min Number: {0}", min);
            Console.WriteLine("Number of Odds: {0}", counter);
 
        }
    }
}

using System;

namespace InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //counting valid entries
            int counterGood = 0;

            //counting invalid enteries 
            int counterBad = 0;

            string input = "";

            do
            {
                Console.WriteLine("Please enter a number 0-99, or type Q to exit");
                input = Console.ReadLine();

                if (!input.ToUpper().Equals("Q"))
                {
                    int number = 0;
                    if(int.TryParse(input, out number))
                    {
                        if(number >= 0 && number <= 99)
                        {
                            counterGood++;
                        } else
                        {
                            counterBad++;
                        }
                    }
                }

            } while (!input.ToUpper().Equals("Q"));

            Console.WriteLine("Valid numbers entered: " + counterGood);
            Console.WriteLine("Invalid numbers entered: " + counterBad);

        }
    }
}

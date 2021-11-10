using System;

namespace BarChart
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            string input;
            int result;
            bool stopInput = false;
            string allInput = "";

            while (!stopInput)
            {
                do
                {
                    validInput = false;
                    Console.WriteLine("Please enter a number between 1 and 10 or enter Q to quit");
                    input = Console.ReadLine();

                    if(int.TryParse(input, out result))
                    {
                        if(result > 0 && result <= 10)
                        {
                            validInput = true;
                            allInput += input + ",";
                        }
                    }

                    if (input.ToUpper().Equals("Q"))
                    {
                        validInput = true;
                        stopInput = true;
                    }

                    if(!validInput)
                    {
                        Console.WriteLine("Invalid Input. The value won't be counted");
                    }

                } while (!validInput);
            }

            string[] numbers = allInput.Split(',');

            for(int i=1; i <= 10; i++)
            {
                Console.Write("\n" + i + "     ");
                for(int j=0; j < numbers.Length-1; j++)
                {
                    if(Convert.ToInt32(numbers[j]) == i)
                    {
                        Console.Write("*");
                    }
                }
            }
        }
    }
}

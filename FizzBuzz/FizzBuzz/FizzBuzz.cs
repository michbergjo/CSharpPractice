using System;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first value: ");
            int firstVal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second value: ");
            int secondVal = Convert.ToInt32(Console.ReadLine());

            FizzBuzzMethod(firstVal, secondVal);
        }
        public static void FizzBuzzMethod(int firstVal, int secondVal)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % firstVal == 0 && i % secondVal == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % firstVal == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % secondVal == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(i + " ");
                }

                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

        }
    }

}
   
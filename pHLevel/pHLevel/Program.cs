using System;

namespace pHLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            int pH;
            Console.WriteLine("Please enter the pH level: ");

            if (int.TryParse(Console.ReadLine(),out pH) == false  || pH < 0 || pH > 14)
            {
                Console.WriteLine("Invalid Input");
            }
            else if(pH < 7)
            {
                Console.WriteLine("pH is Acidic");
            } else if(pH > 7)
            {
                Console.WriteLine("pH is Alkaline");
            } else
            {
                Console.WriteLine("pH is neutral");
            }
        }
    }
}

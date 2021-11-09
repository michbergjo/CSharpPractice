using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginningValue;
            int endingValue;

            do
            {
                Console.WriteLine("Please enter initial value between 2-8");
                beginningValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter final value between 2-8");
                endingValue = Convert.ToInt32(Console.ReadLine());

                if(beginningValue < 2 || endingValue > 8)
                {
                    Console.WriteLine("Invalid Input");
                }

            } while (beginningValue < 2 || endingValue > 8);

            Console.WriteLine("\n");

            for(int i=beginningValue-1; i<=endingValue; i++)
            {
                if(i == beginningValue - 1)
                {
                    Console.Write(String.Format("{0,6}", "n"));
                } else
                {
                    Console.Write(String.Format("{0,6}", i));
                }
            }

            Console.WriteLine("\n");

            for(int i=1; i <= 25; i++)
            {
                Console.Write(String.Format("{0,6}", i));
                /*Console.Write(i);*/

                for (int b = beginningValue; b <= endingValue; b++)
                {
                    string output = String.Format("{0,6}", i * b);
                    Console.Write(output);
                    /*Console.Write(i * b + " ");*/
                }
                Console.WriteLine("");
            }
        }
    }
}

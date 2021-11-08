using System;

namespace GetNameAndSaying
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Message("name");
            string phrase = Message("favorite saying");

            DisplayOutput(name, phrase);
        }

        public static string Message(string msg)
        {
            Console.WriteLine("Please enter your {0}: ", msg);
            return Console.ReadLine();
        }

        public static void DisplayOutput(string name, string phrase)
        {
            Console.WriteLine("\n<><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your favorite saying is {0}", phrase);
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><>\n");
        }
    }
}

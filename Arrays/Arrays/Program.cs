using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            TestArray arr = new TestArray();
            Console.WriteLine("Number of Elements: {0}", arr.NumberOfElements.ToString());
            Console.WriteLine("Number of Valid Elements: {0}", arr.ValidEnteries().ToString());
            Console.WriteLine("Number of Invalid Elements: {0}", arr.NumberOfElements - arr.ValidEnteries());

            int[] entriesCount = arr.CountEntries();
            for(int i=0; i < entriesCount.Length; i++)
            {
                Console.WriteLine("Number of Occurences for Value of {0} is {1} ", i, entriesCount[i]);
            }
        }
    }
}

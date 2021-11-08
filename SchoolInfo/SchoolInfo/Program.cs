using System;

namespace SchoolInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Astricks());
            Console.WriteLine(SchoolInfo());
            Console.WriteLine(Astricks());
        }

    public static string Astricks()
        {
            return "***********************************************************";
        }

    public static string SchoolInfo()
        {
            string schoolName = "University of Michigan";
            string schoolCountry = "USA";
            int schoolCost = 150000;
            int numOfStudents = 5000;
            string schoolInfo = String.Format("School Name: {0}\n" +
                "School Country: {1}\n" + "School Cost: {2:C2}\n" + 
                "Students Attending: {3}", schoolName, schoolCountry, schoolCost, numOfStudents);

            return schoolInfo;
        }
    }
}

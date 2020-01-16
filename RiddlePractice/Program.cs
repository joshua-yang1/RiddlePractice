using System;

namespace RiddlePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string name = (Console.ReadLine().ToLower());
            Console.WriteLine("What is your last name?");
            string lastName = (Console.ReadLine().ToLower());
            Console.WriteLine("Your name is "+name+" "+lastName+".");
            int nameLength = name.Length;
            int lastNameLength = lastName.Length;
            if (nameLength > lastNameLength)
            {
                Console.WriteLine("Your first name is longer.");
            }
            else if (lastNameLength > nameLength)
            {
                Console.WriteLine("Your last name is longer.");
            }
            else
            {
                Console.WriteLine("Your first and last name are the same length.");
            }
            Console.WriteLine("What is long, brown, and sticky?");
            string answer;
            do
            {
                answer = (Console.ReadLine().ToLower());
                if (answer == "stick")
                {
                    Console.WriteLine("That is correct!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }
            }
            while (answer != "stick");
        }
    }
}

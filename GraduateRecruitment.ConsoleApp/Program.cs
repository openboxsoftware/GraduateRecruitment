using System;
using System.Runtime.CompilerServices;
using GraduateRecruitment.ConsoleApp.Data;

[assembly: InternalsVisibleTo("GraduateRecruitment.UnitTests")]

namespace GraduateRecruitment.ConsoleApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var repo = new OpenBarRepository();

            Question1(repo);
            Console.WriteLine(Environment.NewLine);
            Question2(repo);
            Console.WriteLine(Environment.NewLine);
            Question3(repo);
            Console.WriteLine(Environment.NewLine);
            Question4(repo);
            Console.WriteLine(Environment.NewLine);
            Question5(repo);
            Console.WriteLine(Environment.NewLine);
            Question6(repo);
            Console.WriteLine(Environment.NewLine);
            Question7(repo);
            Console.WriteLine(Environment.NewLine);
        }

        private static void Question1(OpenBarRepository repo)
        {
            Console.WriteLine("Question 1: What is the most popular drink, including the quantity, on a Wednesday?");

            // Write your answer to the console here.
            // Format e.g.  {inventory name}: {quantity}
        }

        private static void Question2(OpenBarRepository repo)
        {
            Console.WriteLine("Question 2: What is the most popular drink, including the quantities, per day?");

            // Write your answer to the console here.
            // Format e.g.  {day of week}
            //              {inventory name}: {quantity}
        }

        private static void Question3(OpenBarRepository repo)
        {
            Console.WriteLine("Question 3: Which dates did we run out of Savanna Dry for the last recorded month?");

            // Write your answer to the console here.
            // Format e.g.  {year}/{month}/{day}
        }

        private static void Question4(OpenBarRepository repo)
        {
            Console.WriteLine("Question 4: How many Fanta Oranges do we need to order next week?");

            // Write your answer to the console here.
            // Format e.g.  {quanity}
        }

        private static void Question5(OpenBarRepository repo)
        {
            Console.WriteLine("Question 5: How much do we need to budget next month for Ceres Orange Juice?");

            // Write your answer to the console here.
            // Format e.g.  R{amount}
        }

        private static void Question6(OpenBarRepository repo)
        {
            Console.WriteLine("Question 6: How much do we need to budget for next month to restock the fridge?");

            // Write your answer to the console here.
            // Format e.g.  R{amount}
        }

        private static void Question7(OpenBarRepository repo)
        {
            Console.WriteLine("Question 7: We're planning a braai and expecting 100 people, how many of each drink should we order based on historical popularity of drinks?");

            // Write your answer to the console here.
            // Format e.g.  {inventory name}: {quantity}
        }
    }
}
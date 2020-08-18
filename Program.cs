﻿using System;

namespace EmployeeDatabase
{
    class Program
    {

        static void DisplayGreeting()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("    Welcome to Our Employee Database    ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            var userInput = int.Parse(Console.ReadLine());
            return userInput;
        }
        static void Main(string[] args)
        {
            DisplayGreeting();

            var name = PromptForString("What is your name? ");

            int department = PromptForInteger("What is your department number? ");

            int salary = PromptForInteger("What is your yearly salary (in dollars)? ");

            Console.WriteLine($"Hello, {name} you make {salary / 12} dollars per month.");
        }
    }
}
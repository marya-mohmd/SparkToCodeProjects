using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Text;

namespace SparkToCode.program1
{
    internal class Session2Tasks
    {
        static void Main(string[] args)
        {
            //Task 1: Countdown Timer
            Console.WriteLine("Please Enter a Starting Number:");
            int StartingNumber = int.Parse(Console.ReadLine());
            if (StartingNumber < 1)
            {
                Console.WriteLine("Please Enter a Starting Number Higher Than 1:");
            }
            else
            {
                for (int y = StartingNumber; y >= 1; y--)
                {
                    Console.WriteLine(y);
                }
                Console.WriteLine("Liftoff!");
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 2: Sum of Numbers 1 to N
            Console.WriteLine("Enter a Positive Number:");
            int PosNum = int.Parse(Console.ReadLine());
            int i = 0;
            int sum = 0;

            for (i = 0; i <= PosNum; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("Final Sum is =" + sum);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 3: Multiplication Table
            Console.WriteLine("Enter a Number to Generate Multiplication Table:");
            int Num = int.Parse(Console.ReadLine());
            for (int m = 0; m < Num; m++)
            {
                int result = Num * m;
                Console.WriteLine(Num + " * " + m + " = " + result);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 4: Password Retry
            string correctPassword = "Spark2026";
            string inputPassword = "";

            while (inputPassword != correctPassword)
            {
                Console.WriteLine("Please Enter the Password:");
                inputPassword = Console.ReadLine();
                if (inputPassword != correctPassword)
                {
                    Console.WriteLine("Incorrect Password. Please Try Again.");
                }
                else
                {
                    Console.WriteLine("Access Granted!");
                }
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 5: Number Guessing Game
            Console.WriteLine("Welcome to the Number Guessing Game!");
            int secrettCode = 38;
            int userGuess = 0;
            int attempts = 0;

            do
            {
                Console.WriteLine("Guess the Secret Code:");
                userGuess = int.Parse(Console.ReadLine());
                attempts++;
                if (userGuess < secrettCode)
                {
                    Console.WriteLine("Too Low! Try Again.");
                }
                else if (userGuess > secrettCode)
                {
                    Console.WriteLine("Too High! Try Again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! It took you " + attempts + "attempts.");
                }
            } while (userGuess != secrettCode);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 6: Safe Division Calculator
            try
            {
                Console.WriteLine("Please Enter the First Number:");
                int firstNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter the Second Number:");
                int secondNum = int.Parse(Console.ReadLine());

                int DivideResult = firstNum / secondNum;
                Console.WriteLine("The Result of Division is: " + DivideResult);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed. Please enter a non-zero second number.");

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format. Please enter valid integers.");
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 7: Repeating Menu with Exit Option
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1) Say Hello");
                Console.WriteLine("2) Show Current Time-of-day Greeting");
                Console.WriteLine("3) Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello!");
                            break;
                        case 2:
                            Console.WriteLine("It is 8:00am, Good Morning! Hope you have a great day.");
                            break;
                        case 3:
                            Console.WriteLine("Goodbye!");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 8: Sum of Even Numbers Only
            Console.WriteLine("Enter a Positive Number to Calculate the Sum of Even Numbers:");
            int EvenNum = int.Parse(Console.ReadLine());
            int SumResult = 0;
            
            for (int j=1; j <= EvenNum; j++)
            {
                if (j % 2 == 0)
                {
                    SumResult = SumResult + j;
                }
            }
        }
    }
}



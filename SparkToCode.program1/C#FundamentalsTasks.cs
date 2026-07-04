using System;
using System.Collections.Generic;
using System.Text;

namespace SparkToCode.program1
{
    internal class C_FundamentalsTasks
    {
        static void Main(string[] arg)
        {
            //Task 1: Persoanl Info Card
            Console.WriteLine("Please Enter Your Name: ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Please Enter Your Age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Hight in meters: ");
            double Hight = double.Parse(Console.ReadLine());
            Console.WriteLine("Are you a student? (yes/no): ");
            bool Student = bool.Parse(Console.ReadLine());

            Console.WriteLine("Name: " + UserName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Hieght: " + Hight + " m");
            Console.WriteLine("Student" + Student);

            /////////////////////////////////////////////////////////////////////////////////
            // Task 2: Rectangle Calculator
            Console.WriteLine("To Calculate the area and perimeter of Your Rectangle, Enter Your Values in cm.\n Please Enter the Length of the Rectangle: ");
            double Length = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Width of the Rectangle: ");
            double Width = double.Parse(Console.ReadLine());

            double Area = Length * Width;
            double Perimeter = 2 * (Length + Width);

            Console.WriteLine("The Area of the Rectangle is: " + Area + " cm²");
            Console.WriteLine("The Perimeter of the Rectangle is: " + Perimeter + " cm");

            ////////////////////////////////////////////////////////////////////////////////
            // Task 3: Even or Odd Checker
            Console.WriteLine("Please Enter a Number to Check if it is Even or Odd: ");
            int Num = int.Parse(Console.ReadLine());

            if(Num % 2 == 0) 
            { 
                Console.WriteLine(Num + "is Even");
            }
            else
            {
                Console.WriteLine(Num + "is Odd");
            }

            ///////////////////////////////////////////////////////////////////////////////
            //Task 4: Voting Eligibility
            Console.WriteLine("Please Enter Your Age to Check if You are Eligible to Vote: ");
            int VoterAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Is Your National ID Valid? (yes/no): ");
            bool ValidID = bool.Parse(Console.ReadLine());

            if(VoterAge >= 18 && ValidID)
            {
                Console.WriteLine("You are Eligible to Vote");
            }
            else
            {
                Console.WriteLine("You are Not Eligible to Vote");
            }

            ///////////////////////////////////////////////////////////////////////////////////
            //Task 5: Grade Letter Lookup
            Console.WriteLine("Please Enter Your Grade Letter: ");
            string Grade = Console.ReadLine();

            switch(Grade)
            {
                case "A":
                    Console.WriteLine("Excellent");
                    break;
                case "B":
                    Console.WriteLine("Very Good");
                    break;
                case "C":
                    Console.WriteLine("Good");
                    break;
                case "D":
                    Console.WriteLine("Pass");
                    break;
                case "F":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Grade.");
                    break;
            }

            //////////////////////////////////////////////////////////////////////////////////////
            //Task 6: Temperature Converter
            Console.WriteLine("Please Enter the Temperature in Celsius to Convert to Fahrenheit: ");
            double C = double.Parse(Console.ReadLine());
            double F =( C * 9 / 5 ) + 32;

            string Classification;
            if (C < 10)
            {
                Console.WriteLine("The Temperature in Fahrenhiet is" + F + "(Cold)");
            }
            else if (C >= 10 && C <= 30)
            {
                Console.WriteLine("The Temperature in Fahrenhiet is" + F + "(Mild)");
            }
            else
            {
                Console.WriteLine("The Temperature in Fahrenhiet is" + F + "(Hot)");
            }


            ///////////////////////////////////////////////////////////////////////////////////////
            //Task 7:Movie Ticket Pricing
            Console.WriteLine("Please Enter Your Age To Check You Are in Witch Category:");
            int AgeToCheck = int.Parse(Console.ReadLine());
            if (AgeToCheck >= 0 && AgeToCheck <= 12)
            {
                Console.WriteLine("You are a Child, Your Ticket Price is 2.000 OMR");
            }
            else if (AgeToCheck >= 13 && AgeToCheck <= 59)
            {
                Console.WriteLine("You are an Adult, Your Ticket Price is 5.000 OMR");
            }
            else if (AgeToCheck >= 60)
            {
                Console.WriteLine("You are a Senior Citizen, Your Ticket Price is 3.000 OMR");
            }
            else
            {
                Console.WriteLine("Invalid Age Entered.");
            }


            ///////////////////////////////////////////////////////////////////////////////////////
            //Task 8: Restaurant Bill with Membership Discount
            Console.WriteLine("Please Enter Your Total Bill Amount: ");
            double Bill = double.Parse(Console.ReadLine());

            Console.WriteLine("Are You a Loyalty Member? (yes/no): ");
            bool Member = bool.Parse(Console.ReadLine());

            double Discount = 0;
            if (Bill > 20 && Member)
            {
                Discount = Bill * 0.15;
                Console.WriteLine("You Are A Loyalty Member, You Get a 15% Discount!");
            }
            else
            {
                Discount = 0;
            }

            double FinalAmount = Bill - Discount;

            Console.WriteLine("Original Bill: " + Bill);
            Console.WriteLine("Discount: " + Discount);
            Console.WriteLine("Final Amount to Pay: " + FinalAmount);

            //Task 9: Day Name Finder
            Console.WriteLine("Please Enter a Number (1-7) to Find the Corresponding Day of the Week: ");
            string DayNum = Console.ReadLine();

            switch (DayNum)
            {
                case "1":
                    Console.WriteLine("Sunday");
                    break;
                case "2":
                    Console.WriteLine("Monday");
                    break;
                case "3":
                    Console.WriteLine("Tuesday");
                    break;
                case "4":
                    Console.WriteLine("Wednesday");
                    break;
                case "5":
                    Console.WriteLine("Thursday");
                    break;
                case "6":
                    Console.WriteLine("Friday");
                    break;
                case "7":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Day Number.");
                    break;
            }


            /////////////////////////////////////////////////////////////////////////////////////////
            //Task 10: Mini Calculator
            Console.WriteLine("Please Enter the First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Second Number: ");  
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Choose the Operation:\n" +
                "1.Addition\n" +
                "2.Subtraction\n" +
                "3.Multiplication\n" +
                "4.Division\n" +
                "5.Remainder");
            int operation = int.Parse(Console.ReadLine());

            switch(operation)
            { 
                case 1:
                    Console.WriteLine("The Result of Addition is: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("The Result of Subtraction is: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("The Result of Multiplication is: " + (num1 * num2));
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine("The Result of Division is: " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                case 5:
                    if (num2 != 0)
                    {
                        Console.WriteLine("The Result of Remainder is: " + (num1 % num2));
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                    default:
                    {
                        Console.WriteLine("Invalid Operator.");
                    }
                    break; 
            }


            /////////////////////////////////////////////////////////////////////////////////////////
            //Task 11: Loan Eligibility System
            Console.WriteLine("Please Enter Your Age: ");
            int AgeForLoan = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Monthly Income: ");
            double Income = double.Parse(Console.ReadLine());
            Console.WriteLine("Do You Have an Existing Loan? (yes/no)");
            bool ExistingLoan = bool.Parse(Console.ReadLine());

            if (Age >= 21 && Age <= 60 && Income >= 400 && !ExistingLoan)
            {
                Console.WriteLine("You are eligible for the loan.");
            }
            else
            {
                Console.WriteLine("You are not eligible for the loan.");

                if (Age < 21 || Age > 60)
                {
                    Console.WriteLine("Reason: Age out of range.");
                }
                if (Income < 400)
                {
                    Console.WriteLine("Reason: Income too low.");
                }
                if (ExistingLoan)
                {
                    Console.WriteLine("Reason: Has an existing loan.");
                }
            }


            /////////////////////////////////////////////////////////////////////////////////////////
            //Shipping Cost Calculator
            Console.WriteLine("Please Enter the Weight of the Package in kg: ");
            double Weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Reggion Code: A.Local  B.national  C.international");
            string Region = Console.ReadLine();

            switch(Region)
            {
                case "A":
                    Console.WriteLine("The Shipping Cost for Local Region is: " + (Weight * 1) + " OMR");
                    break;
                case "B":
                    Console.WriteLine("The Shipping Cost for National Region is: " + (Weight * 3) + " OMR");
                    break;
                case "C":
                    Console.WriteLine("The Shipping Cost for International Region is: " + (Weight * 7) + " OMR");
                    break;
                default:
                    Console.WriteLine("Invalid Region.");
                    break;
            }


            /////////////////////////////////////////////////////////////////////////////////////////
            //Task 13: Triangle Type Classifier
            Console.WriteLine("Please Enter the Length of the First Side of the Triangle: ");
            double Side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Length of the Second Side of the Triangle: ");
            double Side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Length of the Third Side of the Triangle: ");
            double Side3 = double.Parse(Console.ReadLine());

            bool isValidTriangle = (Side1 + Side2 > Side3) && (Side1 + Side3 > Side2) && (Side2 + Side3 > Side1);

            if(!isValidTriangle)
            { 
                Console.WriteLine("The given sides do not form a valid triangle.");
            }
            else
            {
                Console.WriteLine("The given sides form a valid triangle.");
                if(Side1 == Side2 && Side2 == Side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (Side1 == Side2 || Side1 == Side3 || Side2 == Side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }


            //////////////////////////////////////////////////////////////////////////////////////////
            //Task 14: Online Store Checkout
            Console.WriteLine("Please Enter the Product Code (1,2,3)");
            string Product = (Console.ReadLine());
            Console.WriteLine("Please Enter the Quantity: ");
            int Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Discount Code (yes/no): ");
            bool DiscountCode = bool.Parse(Console.ReadLine());
            
            string ProductName = "";
            double Price = 0;

            switch (Product)
            {
                case "1":
                    ProductName = "Headphones";
                    Price = 8.500;
                    break;
                case "2":
                    ProductName = "Keyboard";
                    Price = 12.000;
                    break;
                case "3":
                    ProductName = "Mouse";
                    Price = 5.000;
                    break;
                default:
                    Console.WriteLine("Invalid Product Code.");
                    return;
            }
            if(DiscountCode)
            {
            
            double Subtotal = Price * Quantity;

                double DiscountApplied = 0;
                if (DiscountCode && Subtotal > 20)
                {
                    Discount = Subtotal * 0.10;
                }

                double AfterDiscount = Subtotal - Discount;
                double Tax = AfterDiscount * 0.05;
                double Total = AfterDiscount + Tax;

                Console.WriteLine("Product: " + ProductName);
                Console.WriteLine("Subtotal: " + Subtotal + " OMR");
                Console.WriteLine("Discount: " + Discount + " OMR");
                Console.WriteLine("Tax: " + Tax + " OMR");
                Console.WriteLine("Total: " + Total + " OMR");
            }

            //////////////////////////////////////////////////////////////////////////////////////////
            //Task 15: University Admission Decision
            Console.WriteLine("Please Enter Program Type (S for Science, A for Arts): ");
            string ProgramType = (Console.ReadLine());

            Console.WriteLine("Please Enter GPA (out of 4.0): ");
            double GPA = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Entrance Exam Score (out of 100): ");
            double ExamScore = double.Parse(Console.ReadLine());

                Console.WriteLine("Do You Have an Extracurricular Achievement? (yes/no): ");
                bool HasAchievement = bool.Parse(Console.ReadLine());

            bool MeetsRequirements = false;
                bool ValidProgram = true;
                string ProgramName = "";

                switch (ProgramType)
                {
                    case "S":
                        ProgramName = "Science";
                        MeetsRequirements = (GPA >= 3.0 && ExamScore >= 75);
                        break;
                    case "A":
                        ProgramName = "Arts";
                        MeetsRequirements = (GPA >= 2.5 && ExamScore >= 60);
                        break;
                    default:
                        ValidProgram = false;
                        Console.WriteLine("Invalid program type");
                        break;
                }

                if (ValidProgram)
                {
                    string Result;

                    if (MeetsRequirements)
                    {
                        Result = "Admitted";
                    }
                    else if (HasAchievement)
                    {
                        Result = "Conditionally Admitted";
                    }
                    else
                    {
                        Result = "Not Admitted";
                    }

                    Console.WriteLine("Program: " + ProgramName);
                    Console.WriteLine("Result: " + Result);
                }
            }
        }
    }


    }
    
}





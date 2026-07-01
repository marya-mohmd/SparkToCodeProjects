namespace SparkToCode.program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program to show how to take input from user in C# 
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int userAge = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Enter your salary:");
            float userSalary = float.Parse(Console.ReadLine());

            Console.WriteLine("Hello," + userName + "! Welcome to SparkToCode.");

            //////////////////////////////////////////////////////////////////////////////////////////////////////
            //program to show how to perform logical operations in C#

            Console.WriteLine("Enter the first number");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            float secondNumber = float.Parse(Console.ReadLine());

            float addition = firstNumber + secondNumber;
            float subtraction = firstNumber - secondNumber;
            float multiplication = firstNumber * secondNumber;
            float division = firstNumber / secondNumber;
            float remainder = firstNumber % secondNumber;
            bool comparison = firstNumber == secondNumber;

            Console.WriteLine("Addition result " + addition);
            Console.WriteLine("Subtraction result: " + subtraction);
            Console.WriteLine("Multiplication result: " + multiplication);
            Console.WriteLine("Division result: " + division);
            Console.WriteLine("Remainder result: " + remainder);
            Console.WriteLine("Comparision result: " + comparison);

            //////////////////////////////////////////////////////////////////////////////////////////////////////
            //program to show how to use conditional statement in C#

            Console.WriteLine("Enter your degree: ");
            float degree = float.Parse(Console.ReadLine());

            if(degree < 50)
            {
                Console.WriteLine("FAILED");
            }
            else if(degree >= 50 && degree < 60)
            { 
                Console.WriteLine("PASSED! Grade=D");
            }
            else if(degree >= 60 && degree < 70)
            {
                Console.WriteLine("PASSED! Grade=C");
            }
            else if (degree >= 70 && degree <= 80)
            {
                Console.WriteLine("PASSED! Grade=B");
            }
            else if (degree > 80)
            {
                Console.WriteLine("PASSED! Grade=A+");
            }
            else
            {
                Console.WriteLine("Invalid Degree");
        }

            //////////////////////////////////////////////////////////////////////////////////////////////////////
            //program to use switch statement in C#

            Console.WriteLine("Welcome to The Main Menu");
            Console.WriteLine("1. Deposite");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance Check");

            Console.WriteLine("Enter your choice: ");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine("You have selected Deposite");
                    break;
                case 2:
                    Console.WriteLine("You have selected Withdraw");
                    break;
                case 3:
                    Console.WriteLine("You have selected Balance Check");
                    break;
                default:
                    Console.WriteLine("Please Choose a Correct Option");
                    break;
            }
        }
    } 
}
}

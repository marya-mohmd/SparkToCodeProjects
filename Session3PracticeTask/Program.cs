namespace Session3PracticeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Absolute Difference
            Console.WriteLine("Please enter the first number:");
            int FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            int SecondNumber = int.Parse(Console.ReadLine());
            int AbsDiff = Math.Abs(SecondNumber - FirstNumber);

            Console.WriteLine($"The absolute difference between {FirstNumber} and {SecondNumber} is: {AbsDiff}");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 2: Power and Root Explorer
            Console.WriteLine("Please enter a number to calculate its power and root:");
            int number = int.Parse(Console.ReadLine());

            double power = Math.Pow(number, 2);
            double root = Math.Sqrt(number);

            Console.WriteLine($"The square of {number} is: {power}");
            Console.WriteLine($"The square root of {number} is: {root}");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 3: Name Formatter
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            string upper = name.ToUpper();
            string lower = name.ToLower();
            int length = name.Length;

            Console.WriteLine($"Your name in uppercase is: {upper}");
            Console.WriteLine($"Your name in lowercase is: {lower}");
            Console.WriteLine($"The length of your name is: {length} characters");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 4: Subscription End Date
            Console.WriteLine("Please enter the number of days of the free trial:");
            int freeTrialDays = int.Parse(Console.ReadLine());
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = StartDate.AddDays(freeTrialDays);

            Console.WriteLine("Your free trial started on:" + StartDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Your free trial will end on:" + EndDate.ToString("yyyy-MM-dd"));

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 5: Grade Rounding System
            Console.WriteLine("Please enter your raw exam score as a decimal number:");
            double grade = double.Parse(Console.ReadLine());
            double roundedGrade = Math.Round(grade, 2);
            if (roundedGrade >= 60)
            {
                Console.WriteLine($"Your rounded grade is: {roundedGrade}. You have passed the exam.");
            }
            else
            {
                Console.WriteLine($"Your rounded grade is: {roundedGrade}. You have failed the exam.");
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 6: Password Strength Checker
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();
            bool PassLength = password.Length >= 8;
            bool PassContains= password.ToLower().Contains("password");

            if (PassLength && !PassContains)
            {
                Console.WriteLine("Your password is strong.");
            }
            else
            {
                Console.WriteLine("Your password is weak.");
            }
    }
}
}

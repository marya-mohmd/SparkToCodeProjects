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
            bool PassContains = password.ToLower().Contains("password");

            if (PassLength && !PassContains)
            {
                Console.WriteLine("Your password is strong.");
            }
            else
            {
                Console.WriteLine("Your password is weak.");
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 7: Clean Name Comparator
            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Please confirm your username");
            string confirmUsername = Console.ReadLine();

            string trimmed = confirmUsername.Trim();
            string uppercase = trimmed.ToUpper();
            if (uppercase == username.ToUpper())
            {
                Console.WriteLine("The usernames match.");
            }
            else
            {
                Console.WriteLine("The usernames do not match.");
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 8: Mempership Expiration Checker
            Console.WriteLine("Please enter your membership start date (yyyy-MM-dd):");
            string inputDate = Console.ReadLine();
            try
            {
                DateTime startingDate = DateTime.Parse(inputDate);

                Console.WriteLine("Enter the number of valid membership days: ");
                int validDays = int.Parse(Console.ReadLine());

                DateTime expiryDate = startingDate.AddDays(validDays);

                if (expiryDate >= DateTime.Today)
                {
                    Console.WriteLine("Membership status: Active");
                }
                else
                {
                    Console.WriteLine("Membership status: Expired");
                }

                Console.WriteLine("Expiry date: " + expiryDate.ToString("yyyy-MM-dd"));
                }
            catch (FormatException)
            {
                Console.WriteLine("Please restart and enter a valid date.");
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 9: Round Up / Round Down Explorer
            Console.WriteLine("Please enter a decimal number:");
            double decimalNumber = double.Parse(Console.ReadLine());
            double roundedNum = Math.Round(decimalNumber);
            double roundedUp = Math.Ceiling(decimalNumber);
            double roundedDown = Math.Floor(decimalNumber);

            Console.WriteLine("The number rounded to the nearest whole number is:" + roundedNum);
            Console.WriteLine("The number rounded up to the nearest whole number is:" + roundedUp);
            Console.WriteLine("The number rounded down to the nearest whole number is:" + roundedDown);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 10: Word Position Finder
            Console.WriteLine("Please enter a full sentence:");
            string sentence = Console.ReadLine();
            Console.WriteLine("Please enter a word to find its position in the sentence:");
            string word = Console.ReadLine();

            int firstPosition = sentence.IndexOf(word);
            int lastPosition = sentence.LastIndexOf(word);

            if (firstPosition == -1)
            {
                Console.WriteLine("The word '" + word + "' was not found.");
            }
            else
            {
                Console.WriteLine("First occurrence of '" + word + "' is at index: " + firstPosition);
                Console.WriteLine("Last occurrence of '" + word + "' is at index: " + lastPosition);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 11: One-Time Password (OTP) Generator
            Random random = new Random();
            int otp = random.Next(1000, 10000); 

            Console.WriteLine("Your OTP has been sent: " + otp);

            int maxAttempts = 3;
            bool isVerified = false;

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.Write("Attempt " + attempt + " of " + maxAttempts + " - Enter the OTP: ");
                string input = Console.ReadLine();

                try
                {
                    int enteredCode = int.Parse(input);

                    if (enteredCode == otp)
                    {
                        Console.WriteLine("Verified");
                        isVerified = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect code.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numbers only.");
                }
            }

            if (!isVerified)
            {
                Console.WriteLine("Verification Failed");
            }
        }
    }
}

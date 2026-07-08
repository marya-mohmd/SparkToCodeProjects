namespace Session4PracticeTask
{
    internal class Program
    {
        //Task 1 - Personalized Welcome Function
        public static void PrintWelcomeMessage(string name)
        {
            Console.WriteLine("Welcome to Spark to Code, " + name);
        }
        //Task 2 - Square Number Function
        public static int Square(int number)
        {
            int square = number * number;
            return square;
        }
        /*static void Main(string[] args)
        {
        Console.WriteLine("Enter a number:");
        int userNumber = int.Parse(Console.ReadLine());

        int squaredResult = Square(userNumber);

        Console.WriteLine($"The square of {userNumber} is {squaredResult}");
        } */

        //Task 3 - Celsius to Fahrenheit Function
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        /* static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in Celsius:");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine(celsius + "=°C is equal to" + fahrenheit + "°F");
        } */

        //Task 4 - Fixed Menu Display Function
        public static void DisplayMenu()
        {
            Console.WriteLine("------Menu-------");
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }
        /*static void Main(string[] args)
        {
            DisplayMenu();
        } */


        //Task 5 - Even or Odd Function
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int uNumber = int.Parse(Console.ReadLine());
            if (IsEven(uNumber))
            {
                Console.WriteLine("Even.");
            }
            else
            {
                Console.WriteLine("Odd.");
            }
        } */

        //Task 6 - Rectangle Area & Perimeter Functions
        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }
        public static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }
        /* static void Main(string[] args)
        {
            Console.WriteLine("Enter length of the rectangle:");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width of the rectangle:");
            double width = double.Parse(Console.ReadLine());
            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);
            Console.WriteLine("Area:" + area);
            Console.WriteLine("Perimeter:" + perimeter);
        } */

        //Task 7 - Grade Letter Function
        public static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        /* static void Main(string[] args)
        {
            Console.WriteLine("Enter your score:");
            int score = int.Parse(Console.ReadLine());
            string gradeLetter = GetGradeLetter(score);
            Console.WriteLine("Your grade letter is: " + gradeLetter);
        } */

        //Task 8 - Countdown Function
        public static void Countdown(int start)
        {
            for (int i = start; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        /* static void Main(string[] args)
        {
            Console.WriteLine("Enter a starting number for countdown:");
            int startNumber = int.Parse(Console.ReadLine());
            Countdown(startNumber);

        } */

        //Task 9 - Overloaded Multiply Function
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers to multiply:");
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Product of two integers: " + Multiply(int1, int2));
            Console.WriteLine("Enter two doubles to multiply:");
            double double1 = double.Parse(Console.ReadLine());
            double double2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Product of two doubles: " + Multiply(double1, double2));
            Console.WriteLine("Enter three integers to multiply:");
            int int3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Product of three integers: " + Multiply(int1, int2, int3));
        }
}
}

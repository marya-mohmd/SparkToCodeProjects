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
        static void Main(string[] args)
        {
            DisplayMenu();
        }
}
}

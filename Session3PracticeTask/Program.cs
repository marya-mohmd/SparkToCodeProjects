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
        }
    }
}

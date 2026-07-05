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
        }
    }
}

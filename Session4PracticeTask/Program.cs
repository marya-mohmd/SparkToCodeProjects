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
        public static void Square(int number)
        {
            int square = number * number;
            Console.WriteLine("The square of " + number + " is: " + square);
        }
    }
}

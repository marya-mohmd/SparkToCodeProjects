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
            static void Main(string[] args)
            {
            Console.WriteLine("Enter a number:");
            int userNumber = int.Parse(Console.ReadLine());

            int squaredResult = Square(userNumber);

            Console.WriteLine($"The square of {userNumber} is {squaredResult}");
            }
            
        
    }
}

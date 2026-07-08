namespace Session_5_PracticeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Fixed Grades Array
            int[] grades = new int[5];
            
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Enter the grade of each subject:");
                grades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The grades are:");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);

            }
        }
    }
}

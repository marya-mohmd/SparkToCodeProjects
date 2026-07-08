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

            //Task 2 - Dynamic To-Do List
            List<string> todoList = new List<string>();
            Console.WriteLine("Enter 5 of your to-do tasks:");
            for (int i = 0; i < 5; i++)
            {
                string item = Console.ReadLine();
                todoList.Add(item);
            }
            Console.WriteLine("Your to-do list:");
            Console.WriteLine("1." + todoList[0]);
            Console.WriteLine("2." + todoList[1]);
            Console.WriteLine("3." + todoList[2]);
            Console.WriteLine("4." + todoList[3]);
            Console.WriteLine("5." + todoList[4]);

            //Task 3 - Browsing History Stack
            Stack<string> webPage = new Stack<string>();


            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter website URL" + i);
                string URL = Console.ReadLine();
                webPage.Push(URL);
            }
            string backToPage = webPage.Pop();
            Console.WriteLine("You went back from: " + backToPage);

            //Task 4 - Customer Service Queue
            Queue<string> customerService = new Queue<string>();

            for (int n = 0; n < 3; n++)
            {
                Console.Write("Enter customer name" + n);
                string customerName = Console.ReadLine();
                customerService.Enqueue(customerName);
            }
            Console.WriteLine($"\nNumber of customers waiting: {customerService.Count}");
            var servedCustomer = customerService.Dequeue();
            Console.WriteLine($"\n Served Customer Name: {servedCustomer}");
            Console.WriteLine($"\nNumber of customers waiting: {customerService.Count}");

            //Task 5 - Array Grade Range
            int[] studentGrades = new int[5];
            for (int i = 0; i < studentGrades.Length; i++)
            {
                Console.WriteLine("Enter your grade:");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(studentGrades);
            double avgGrade = (studentGrades[0] + studentGrades[1] + studentGrades[2] + studentGrades[3] + studentGrades[4]) / 5;

            Console.WriteLine("The lowest grade is: " + studentGrades[0]);
            Console.WriteLine("The highest grade is: " + studentGrades[4]);
            Console.WriteLine("The average grade is: " + avgGrade);
        }
    }
}

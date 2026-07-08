using System.Xml;

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

            //Task 6 - Filtered Shopping List
            List<string> shoppingList = new List<string>();
            Console.WriteLine("Welcome to our store! Type 'done' when you are finished adding items.");
            while (true)
            {

                Console.WriteLine("Enter an item to add to your shopping list:");
                string item = Console.ReadLine();
                if (item.ToLower() == "done")
                {
                    break;
                }
                shoppingList.Add(item);
            }
            Console.WriteLine("The original shopping list:");
            Console.WriteLine(string.Join(", ", shoppingList));
            Console.WriteLine("Select one item from your shopping list to remove:");
            string itemToRemove = Console.ReadLine();
            shoppingList.Remove(itemToRemove);


            Console.WriteLine("Your updated shopping list:");
            Console.WriteLine(string.Join(", ", shoppingList));

            //Task 7 - High Score Podium
            List<int> scores = new List<int>();
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Enter your score:");
                int score = int.Parse(Console.ReadLine());
                scores.Add(score);
            }
            scores.Sort();
            scores.Reverse();
            Console.WriteLine("The 1st Place is: " + scores[0]);
            Console.WriteLine("The 2nd Place is: " + scores[1]);
            Console.WriteLine("The 3rd Place is: " + scores[2]);

            //Task 8 - Undo Last Action
            Stack<string> actions = new Stack<string>();
            while (true)
            {
                Console.WriteLine("Enter an action (or type 'stop' to finish):");
                string action = Console.ReadLine();

                if (action.ToLower() == "stop")
                {
                    break;
                }

                actions.Push(action);
            }
            string firstUndo = actions.Pop();
            Console.WriteLine($"Undo: {firstUndo}");

            string secondUndo = actions.Pop();
            Console.WriteLine($"Undo: {secondUndo}");

            Console.WriteLine("\nRemaining actions in history:");
            foreach (string action in actions)
            {
                Console.WriteLine(action);
            }

        }

        //Task 9 - Grade Analyzer with Functions
        //static double CalculateAverage(List<int> yourgrades)
        //{
        //    double sum = 0;
        //    foreach (int subGrade in yourgrades)
        //    {
        //        sum += subGrade;
        //    }
        //    return sum / yourgrades.Count;
        //}

        //static int FindFirstFailing(List<int> yourgrades)
        //{
        //    return yourgrades.Find(x => x < 60);
        //}

        //    static void Main(string[] args)
        //    {
        //        Console.Write("How many grades do you want to enter? ");
        //        int count = int.Parse(Console.ReadLine());

        //        List<int> yourgrades = new List<int>();

        //        for (int i = 0; i < count; i++)
        //        {
        //            Console.Write($"Enter grade {i + 1}: ");
        //            int subGrade = int.Parse(Console.ReadLine());
        //            yourgrades.Add(subGrade);
        //            double average = CalculateAverage(yourgrades);
        //            int firstFailing = FindFirstFailing(yourgrades);

        //            Console.WriteLine($"\nAverage grade: {average:F2}");

        //            // .Find returns 0 (default for int) when no match is found,
        //            // but 0 could also be a real grade, so we check for that explicitly.
        //            if (firstFailing == 0 && !yourgrades.Contains(0))
        //            {
        //                Console.WriteLine("No failing grades found.");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"First failing grade: {firstFailing}");
        //            }
        //        }

        //    }

        //Task 10 - Print Queue Manager
        Queue<string> printQueue = new Queue<string>();
        
    }
}

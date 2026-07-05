using System;
using System.Collections.Generic;
using System.Text;

namespace SparkToCode.program1
{
    internal class Session2Tasks
    {
        static void Main(string[] args)
        {
            //Task 1: Countdown Timer
            Console.WriteLine("Please Enter a Starting Number:");
            int StartingNumber = int.Parse(Console.ReadLine()); 
            if (StartingNumber < 1) 
            {
                Console.WriteLine("Please Enter a Starting Number Higher Than 1:");
            }
            else
            {
                for(int y = StartingNumber; y >= 1; y--)
                {
                    Console.WriteLine(y);
                }
                Console.WriteLine("Liftoff!");
            }

            
    }
}
}

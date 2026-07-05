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

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Task 2: Sum of Numbers 1 to N
            Console.WriteLine("Enter a Positive Number:");
            int PosNum = int.Parse(Console.ReadLine());
            int i = 0;
            int sum = 0;

            for (i = 0; i <= PosNum; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("Final Sum is =" + sum);

            
        }
}
}

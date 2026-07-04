using System;
using System.Collections.Generic;
using System.Text;

namespace SparkToCode.program1
{
    internal class Session2
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////
            //for loop
            int counter = 0;
            for(counter=1;  counter<=5; counter++) 
            {
                Console.WriteLine("certaine message");            
            }

            //////////////////////////////////////////////////////////////////////////////////
            //while loop and do-while
            bool exitDecetion = false;
            string userInput;

            do
            {
                Console.WriteLine("Print menu:");

                Console.WriteLine("Do you want to exit? (y/n)");
                userInput = Console.ReadLine();

                if (userInput == "y")
                {
                    exitDecetion = true;
                }
            }
            while (exitDecetion == false);
            {
                
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssinment
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking user to input a number
            Console.WriteLine("Input a number");
            
            //bool flag for while loop 
            bool continueInput = true;
            //loop for more inputs if desired
            while (continueInput == true)
            {
                //casting number to int
                int userInput = Convert.ToInt32(Console.ReadLine());
                //using streamwriter to log input to text file, and letting it append new inputs
                using (StreamWriter file = new StreamWriter(@"C:\Users\tbran\Logs\assignLog.txt", true))
                    {
                        file.WriteLine(userInput);
                    }
                Console.WriteLine($"The input: {userInput}, has been logged");
                Console.WriteLine("More inputs? Please answer yes or no.");
                string answer = Console.ReadLine().ToLower();
                if (answer == "no")
                {
                    //ends while loop condition
                    continueInput = false;
                }
                
            }
            
            
            Console.WriteLine("Input Log:");
            //using streamreader to print all inputs to screen, inputs from previous console runs too.
            using (StreamReader file = new StreamReader(@"C:\Users\tbran\Logs\assignLog.txt"))
            {
                Console.WriteLine(file.ReadToEnd());
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number to divide by numbers in list.");
            List<int> intList = new List<int>() { 45, 32, 103, 84, 95 };
            bool tryAgain = false;//flag for while loop
            while (tryAgain == false) //loop to execute try/catch block if conditions met
            {
                try 
                { 
                    tryAgain = true;//used to meet loop conditions
                    int userInt = Convert.ToInt32(Console.ReadLine());
                    foreach (int i in intList)
                    {
                        int u = i / userInt;
                        int r = i % userInt;//threw in modulus for practice
                        Console.WriteLine($"{ i} divided by {userInt} equals {u} with a remainder of {r}");
                    }
                    
                }
                catch (FormatException)//exception used if any data type other than int is used
                {
                    tryAgain = false;//while loop conditions not met
                    Console.WriteLine("Please enter a whole number and try again.");
                }
                catch (DivideByZeroException)//exception used if user divides by zero
                {
                    tryAgain = false;
                    Console.WriteLine("Please do not divide by zero and try again");
                }
                catch (Exception ex)
                {
                    tryAgain = false;
                    Console.WriteLine(ex.Message);
                }
                
            }
            Console.WriteLine("Code was executed!");//executed after loop conditions met
            Console.ReadLine();
        }
    }
}

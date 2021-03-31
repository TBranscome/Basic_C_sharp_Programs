using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate object with string as generic parameter
            Employee<string> employee1 = new Employee<string>() { firstName = "Tyler", lastName = "B", Id = 1 };
            employee1.things = new List<string>() { "laptop", "bag", "phone" };
            ////Instantiate object with int as generic parameter
            Employee<int> employee2 = new Employee<int>() { firstName = "Emily", lastName = "T", Id = 2 };
            employee2.things = new List<int>() { 7, 45, 89 };
            //loops that print all things to console
            foreach (string thing in employee1.things)
            {
                //prints all strings in loop
                Console.WriteLine($"{employee1.firstName} brought his {thing} to work.");
            }
            foreach (int thing in employee2.things)
            {
                //prints all int in loop
                Console.WriteLine($"{employee2.firstName} is working on project number {thing} at work today.");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.Implement the SayName() method inside of the Employee class.
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();
            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it
            IQuittable quittable = new Employee();
            quittable.Quit(employee);
            Console.ReadLine();
        }
    }
}

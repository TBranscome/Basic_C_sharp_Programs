using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate employee1 with Id of 1
            Employee employee1 = new Employee() { firstName = "Tyler", lastName = "B", Id = 1 };
            //Instantiate employee2 with Id of 2
            Employee employee2 = new Employee() { firstName = "Emily", lastName = "T", Id = 2 };
            //Instantiate employee3 with Id of 1
            Employee employee3 = new Employee() { firstName = "Grayson", lastName = "B", Id = 1 };
            //Compare Id of employee1 with employee2 and print response
            bool doesEqual = employee1 == employee2;
            //Compare Id of employee1 with employee3 and print response
            doesEqual = employee1 == employee3;
            Console.ReadLine();

            
            


        }
    }
}

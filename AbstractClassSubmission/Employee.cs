using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public class Employee : Person
    {
        public override void SayName()
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Name: [{fullName}]");
        }
    }
}

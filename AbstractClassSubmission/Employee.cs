using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Name: [{fullName}]");
        }
        public void Quit(Employee employee)
        {
            bool canQuit = true;
            Console.WriteLine($"Can this person quit anytime: {canQuit}");
        }

    }
}

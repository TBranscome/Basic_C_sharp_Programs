using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating new number struct and giving decimal value
            Number number1 = new Number();
            number1.Amount = 1.95;
            //printing amount to console
            Console.WriteLine(number1.Amount);
            Console.ReadLine();
        }
    }
}

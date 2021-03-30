using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mathClass = new MathClass();
            

            MathClass.MathOp(num1: 30, num2: 45); 

            Console.WriteLine();

            MathClass.MathOp(87, 90);

            Console.ReadLine();
        }
    }
}

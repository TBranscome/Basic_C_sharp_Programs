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
            int num1 = 78;
            int num2 = 30;

            MathClass.MathOp(num1, num2); 

            Console.WriteLine();

            MathClass.MathOp(87, 90);

            Console.ReadLine();
        }
    }
}

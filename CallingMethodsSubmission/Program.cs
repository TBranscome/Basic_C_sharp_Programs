using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMathClass MathObject = new MyMathClass();
            Console.WriteLine(MathObject.Area());
            Console.WriteLine(MyMathClass.OnePlus());
            Console.WriteLine(MyMathClass.MinusOne());
            Console.ReadLine();
            

        }
    }
}

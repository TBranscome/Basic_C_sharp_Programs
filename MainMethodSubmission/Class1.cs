using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class MyMathClass
    {
        public int MainMath(int num1)
        {
            int num2 = 2;
            Console.WriteLine("Your number multiplied by two is:");
            return num1 * num2;
        }
        public double MainMath(double numPlus)
        {
            double num2 = 5.45;
            Console.WriteLine("Your number plus 5.45 as an integer is:");
            int num1ToInt = Convert.ToInt32(numPlus);
            int num2ToInt = Convert.ToInt32(num2);
            return num1ToInt + num2ToInt;
        }
        public int MainMath(string numMinus)
        {
            int numConvert = Convert.ToInt32(numMinus);
            int num2 = 77;
            Console.WriteLine("Your number subtracted from seventy seven is:");
            return num2 - numConvert;
        }
    }
}

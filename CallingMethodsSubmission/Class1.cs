using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    public class MyMathClass
    {
        public int Area()
        {
            Console.WriteLine("Input a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int b = num1;
            int h = num2;
            Console.WriteLine($"If your numbers were the base and height of a square, the area would be:");
            return b * h;

        }
        public static int OnePlus()
        {
            Console.WriteLine("Input a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Your numbers plus one are:");
            return num1+1;
        }
        public static int MinusOne()
        {
            Console.WriteLine("Input a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Your numbers minus one are:");
            return num1-1;
            
        }
    }
}

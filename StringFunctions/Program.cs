using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Tyler";
            //string quote = "The man said, \"Hello, Tyler.\"\nHello on a new line.\n\tHello on a new tab.";
            //string fileName = @"C:\Users\tbran";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("r");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(length);
            //Console.WriteLine(quote);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(name);
            //Console.ReadLine();

           

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Tyler");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

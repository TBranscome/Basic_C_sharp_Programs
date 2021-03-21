using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] names = { "Hello, ", "Howdy ", "Bonjour, ", "How are you, " };
            Console.WriteLine("Please add your name.");
            string userInput = Console.ReadLine();
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i] + userInput + "!";
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            if (names[3] == "How are you, " + userInput + "!")
            {
                Console.WriteLine("Great!");
            }
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(names[i]);
            }

            //
            //
            //

            List<string> listColors = new List<string>() { "red", "blue", "yellow" };

            Console.WriteLine("Input a primary color to find index.");
            string colorInput = Console.ReadLine();

            foreach (string color in listColors)
            {
                int c = listColors.IndexOf(color);
                if (listColors[c] == colorInput)
                {
                    Console.WriteLine("Value of index: " + c);
                    break;
                }
                if (color != colorInput)
                {
                    c++;
                }
                if (c >= listColors.Count)
                {
                    Console.WriteLine("no");
                }
            }

            //
            //
            //

            List<string> listFruit = new List<string>() { "apple", "banana", "grape", "apple", "strawberry", "grape" };

            Console.WriteLine("Name a type of fruit to find its index, or indices.");
            string inputFruit = Console.ReadLine();


            
            











            Console.ReadLine();

        }

    }
}

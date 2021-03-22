using System;
using System.Collections.Generic;


namespace IterationAssignment
{
    class Program
    {
        static void Main()
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

            // 1.A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            List<string> listFruit = new List<string>() { "apple", "banana", "grape", "apple", "strawberry", "grape" };

            Console.WriteLine("Name a type of fruit to find its index, or indices.");
            string inputFruit = Console.ReadLine();

            // 2.Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.
            bool exists = false;
            for (int i = 0; i < listFruit.Count; i++)
            {
                if (listFruit[i] == inputFruit)
                {
                    Console.WriteLine(i);
                    exists = true;
                }
                // 3.Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
                if (exists == false && i == listFruit.Count-1)
                {
                    Console.WriteLine("Does not exist");
                }

            }
            // 4.Save and execute your code.
            Console.ReadLine();

        }

    }
}

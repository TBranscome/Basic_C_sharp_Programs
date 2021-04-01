using System;
using System.Collections.Generic;


namespace IterationAssignment
{
    class Program
    {
        static void Main()
        {

            //====== PART ONE =======

            // 1. Create a one-dimensional array of strings.
            string[] greeting = { "Hello, ", "Howdy ", "Bonjour, ", "How are you, " };
            // 2. Ask the user to input some text.
            Console.WriteLine("Please add your name.");
            string userInput = Console.ReadLine();
            Console.WriteLine();//line break
            // 3. A loop that iterates through each string in the array and adds the user's
            // text input to the end of each string. This step will not output anything to the
            // console, but will update each array element by appending the user's text.
            for (int i = 0; i < greeting.Length; i++)
            {
                greeting[i] = greeting[i] + userInput + "!";
            }
            // 4. Then create a loop that prints off each string in the array on a separate line.
            for (int i = 0; i < greeting.Length; i++)
            {
                Console.WriteLine(greeting[i]);
            }

            //========= PART TWO =========

            // 1. An infinite loop.
            // 2. Fix the infinite loop so that                                                  
            //    it will execute properly.
            if (greeting[3] == ("How are you, " + userInput + "!"))
            //Changed while to if
            {
                Console.WriteLine("Great!");
            }

            //========== PART THREE =========

            // 1. A loop where the comparison that’s used to determine whether
            // to continue iterating the loop is a “<” operator.
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(greeting[i]);
            }
            // 2. A loop where the comparison that’s used to determine whether
            // to continue iterating the loop is a “<=” operator.
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(greeting[i]);
            }

            Console.WriteLine();//line break

            //======== PART FOUR =========

            // 1. A list of strings where each item in the list is unique.
            List<string> listColors = new List<string>() { "red", "blue", "yellow" };
            // 2. Ask the user to input text to search for in the list
            Console.WriteLine("Input a primary color to find index.");
            string colorInput = Console.ReadLine();
            // 3. A loop that iterates through the list and then displays the index of the
            // list that contains matching text on the screen.
            foreach (string color in listColors)
            {
                int c = listColors.IndexOf(color);
                if (listColors[c] == colorInput)
                {
                    Console.WriteLine("Value of index: " + c);
                    break;// 5. Add code to the loop that stops it from executing once a
                          // match has been found.

                }
                if (color != colorInput)
                {
                    c++;
                }
                if (c >= listColors.Count)
                {
                    // 4. Add code to the loop to check if the user put in text that isn't on
                    // the list and, if they did, tells the user their input is not on the list.
                    Console.WriteLine("No index found.");
                }
            }

            Console.WriteLine();//linebreak

            //============= PART FIVE =============

            // 1.A list of strings that has at least two identical strings in the list.
            // Ask the user to select text to search for in the list.
            List<string> listFruit = new List<string>() { "apple", "banana", "grape", "apple",
                "strawberry", "grape" };

            Console.WriteLine("Name a type of fruit to find its index, or indices.");
            string inputFruit = Console.ReadLine();

            // 2.Create a loop that iterates through the loop and then displays the indices
            // of the array that contain matching text on the screen.
            bool exists = false;
            for (int i = 0; i < listFruit.Count; i++)
            {
                if (listFruit[i] == inputFruit)
                {
                    Console.WriteLine(i);
                    exists = true;
                }
                // 3.Add code to the loop to check if the user put in text that isn't on the list and,
                // if they did, tells the user their input is not on the list.
                if (exists == false && i == listFruit.Count - 1)
                {
                    Console.WriteLine("Does not exist in list.");
                }

            }
            Console.WriteLine();//linebreak

            // ============= PART SIX ================

            List<string> petsList = new List<string>() { "cat", "dog", "cat", "snake", "hedgehog", "dog" };

            List<int> petCount = new List<int>() { };

            Console.WriteLine("Type in a pet type to find if it is on list: ");
            string userPet = Console.ReadLine();
            foreach (string pet in petsList)
            {
                if (pet == userPet)
                {
                    petCount.Add(1);
                }
            }

            foreach (int num in petCount)
            {
                int count = petCount.Count;
                if (count >= 1)// is on list
                {
                    Console.WriteLine($"The type: {userPet} occurs {count} times.");
                    break;
                }
                if (count == 0)// not on list
                {
                    Console.WriteLine($"{userPet} occurs {count} times.");
                }
            }
            Console.ReadLine();

        }

    }
}

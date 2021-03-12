using System;


namespace While_DoWhile
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Can you guess my favorite color?");
            Console.WriteLine("Guess a color:");
            string color = Console.ReadLine();//user input string value
            bool favColor = color == "purple";//variable favColor is true when purple is input

            do//do while loop added so the correct guess is still displayed properly
            {
                switch (color)//switch statement using the input color
                {
                    case "blue"://case for the input 
                        Console.WriteLine("You guessed blue. Try again.");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();//user input
                        break;//break so loop ends without running the ret of cases automatically
                    case "red":
                        Console.WriteLine("You guessed red. Try again.");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("You guessed yellow. Try again.");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;
                    case "purple":
                        Console.WriteLine("You guessed purple. That is correct!!!");
                        favColor = true;//stating favColor is true and the answer is correct
                        break;
                    default://defaut for any answer not associated with a case
                        Console.WriteLine("You guessed " + color + ". Try again.");
                        Console.WriteLine("Guess a color:");
                        color = Console.ReadLine();
                        break;
                }
            }
            while (!favColor);//while loop to be used when favColor is false

            Console.Read();
        }
    }
}

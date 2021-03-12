using System;


namespace ShippingQuoteProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.");
            Console.WriteLine("Please follow the instructions below:");
            Console.WriteLine();
            Console.WriteLine("What is your package weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else if (weight <= 50)
            {
                Console.WriteLine("What is the package width?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                int length = Convert.ToInt32(Console.ReadLine());
                int dimension = height + width + length;
                if (dimension > 50)
                {
                    Console.WriteLine("Package to big to be shipped via Package Express. Have a good day.");
                }
                else if (dimension <= 50)
                {
                    int dimNum = height * width * length * weight;
                    int quote = dimNum / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + .00);
                }
            }
            else
            {
                Console.WriteLine("Please follow the instructions and try again.");
            }
            Console.ReadLine();
        }
    }
}

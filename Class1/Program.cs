using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {

            double length;
            double width;
            {

                Console.WriteLine("What is the length of the room? (note: Please answer in total inches) Ex. 10 feet 8 inches would be written as: 128)");
                length = Double.Parse(Console.ReadLine());
                Console.WriteLine("What is the width of the room?");
                width = Double.Parse(Console.ReadLine());

                {
                    double total = ((length) * (width)) / 144;
                    Console.WriteLine("The total square footage of the room is " + total); 
                }
            }
        }

    }
}

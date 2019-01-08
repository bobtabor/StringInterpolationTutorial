using System;

namespace StringInterpolationTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bob";
            string date = "Tuesday";

            // There's two parts to string interpolation:
            // 1. Add a $ dollar sign before the literal string.
            // 2. Use {} to merge a variable into the literal string.

            Console.WriteLine($"Hello {name}, it's {date}!");

            // While you can merge like this:
            // string message = $"Hello {name}, it's {date}!";
            // Console.WriteLine(message);

            // You can't do this:
            // string message = "Hello {name}, it's {date}!";
            // Console.WriteLine($message);
        }
    }
}

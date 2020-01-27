using System;

namespace Increment
{
    class Program
    {


        static void Main(string[] args)
        {
            string input = "17";
            var count = Int32.Parse($"{input}");
            ++count;
            Console.WriteLine($"{count}");
        }
    }
}

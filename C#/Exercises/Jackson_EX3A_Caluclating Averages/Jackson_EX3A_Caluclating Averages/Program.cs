using System;
using System.Linq;

namespace Jackson_EX3A_Caluclating_Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            //User inputs an Integer from 0-100 ten times.

            Console.Write("Please enter a number between 0 and 100: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a number between 0 and 100: ");
            int input2 = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a number between 0 and 100: ");
            int input3 = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a number between 0 and 100: ");
            int input4 = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a number between 0 and 100: ");
            int input5 = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a number between 0 and 100: ");
            int input6 = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a number between 0 and 100: ");
            int input7 = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a number between 0 and 100: ");
            int input8 = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a number between 0 and 100: ");
            int input9 = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a number between 0 and 100: ");
            int input10 =Int32.Parse(Console.ReadLine());

            //Adds up the 10 integers that the user input, calculates the sum and the average.

            int sum = input + input2 + input3 + input4 + input5 + input6 + input7 + input8 + input9 + input10;
            Console.WriteLine($"The sum of the integers you entered is: {sum}");
            int average = sum / 10;

            //Based on the average, writes to console the average and the letter grade associated with the average.

            if (average <= 59)
            {
                Console.WriteLine($"The average of the class is: {average}. The letter grade is F.");
            }
            if (average >= 60 && average <= 69)
            {
                Console.WriteLine($"The average of the class is: {average}. The letter grade is D.");
            }
            if (average >= 70 && average <= 79)
            {
                Console.WriteLine($"The average of the class is: {average}. The letter grade is C.");
            }
            if (average >= 80 && average <= 89)
            {
                Console.WriteLine($"The average of the class is: {average}. The letter grade is B.");
            }
            if (average >= 90 && average <= 99)
            {
                Console.WriteLine($"The average of the class is: {average}. The letter grade is A.");
            }
            if (average == 100)
            {
                Console.WriteLine($"The average of the class is: {average}. Perfect Score!");
            }
        }
    }
}
            
          
        




       


        //Basic Difficulty
        //Sum of numbers
        //Create a console application that will accept ten numbers between 0 and 100, and report their sum.
        //
        //
        //Average ten scores
        //Create a console application that will accept ten test scores between 0 and 100, average them, and report a letter grade for the average based on the usual scale.For example, a teacher will input ten test scores and see the average numerical grade and the letter grade.
        //
        //
        //Intermediate Difficulty
        //Average a specific number of scores
        //Create a console application that will accept an arbitrary number test scores (as specified by the user) between 0 and 100, average them, and report a letter grade for the average based on the usual scale.For example, a teacher will input the total number of tests, then input ten test scores and see the average numerical grade and the letter grade.
        //
        //
        //Advanced Difficulty
        //Average a non-specific number of scores
        //Create a console application that will accept a number test scores (as calculated by the number of scores actually entered) between 0 and 100, average them, and report a letter grade for the average based on the usual scale.For example, a teacher will input any number test scores, and see the average numerical grade and the letter grade.

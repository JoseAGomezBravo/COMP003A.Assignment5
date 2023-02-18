/*
 * Author: Jose Angel Gomez Bravo
 * Course: COMP003A
 * Purpose: Replicate the output
 */

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("Triangle Section");

            Console.Write("Enter a single character: ");
            char inputChar = Console.ReadKey().KeyChar;

            

            Console.Write("\nEnter a positive whole number: ");
            int Size = int.Parse(Console.ReadLine());

            IsoscelesTriangleBuilder(inputChar, Size);

            PrintSeparator("Favorite Characters Section");

            CharacterInfo("Spawn", 1992);
            CharacterInfo("Ted Mosby", 1978);
            CharacterInfo("Ultimate Warrior", 1959);
            CharacterInfo("Marvin the Martin", 1948);
            CharacterInfo("Himura Kenshin", 1849);

        }


        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '*'));
        }

        /// <summary>
        /// Outputs a section divider with the inputed header
        /// </summary>
        /// <param name="parameter">Name of header</param>
        static void PrintSeparator(string parameter)
        {
            PrintSeparator();
            Console.WriteLine($"\t {parameter}");
            PrintSeparator();
        }

        /// <summary>
        /// Creates an isosceles triangle according to the users input, size input + character input
        /// </summary>
        /// <param name="inputCharacters">Character used in the triangle</param>
        /// <param name="size">The size of the triangle</param>
        static void IsoscelesTriangleBuilder(char inputCharacters, int size)
        {

            for (int t = 1; t <= size; t++) 
            {
                Console.WriteLine(new string(inputCharacters, t));
            }


            for (int t = size -1; t >= 1; t--)
            {
                Console.WriteLine(new string(inputCharacters, t));
            }

        }

        /// <summary>
        /// Subtracts current year with year born to give age.
        /// </summary>
        /// <param name="year">Year born</param>
        /// <returns>Current age of character</returns>
        static int AgeCalculator(int year)
        {

            return DateTime.Now.Year - year;

        }

        /// <summary>
        /// Calls for the AgeCalculator, which gives the age of the person, therefore using outputing the name and current age of character
        /// </summary>
        /// <param name="name">Character's name</param>
        /// <param name="birthyear">Year born</param>
        static void CharacterInfo(string name, int birthyear)
        {
            int output = AgeCalculator(birthyear);

            Console.WriteLine($"{name} turns {output} this year!");

        }
    }
}
using System;
using System.Collections.Generic;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type a few letters");
            var newString = Console.ReadLine();

            Console.WriteLine($"You typed '{newString.ToUpper()}'");

            List<string> lettersCapsList = new List<string>();

            for (var i = 0; i < newString.Length; i ++)
            {
                string firstLetter = newString[i].ToString().ToUpper();
                lettersCapsList.Add(firstLetter);
                Console.Write(firstLetter);

                int counter = i;

                for (var j = 0; j < counter; j++)
                {
                    Console.Write(newString[i]);
                }
                Console.Write("-");
            }

            char[] charArr = newString.ToCharArray();

            // newString = String.Join<char>(",", newString) + ", ";

            foreach (char c in newString)
            {
              // Console.WriteLine(c.ToString());
            }

            List<string> upperLowerLetters = new List<string>();

            int index = 0;

            foreach (char letter in charArr)
            {
                var upperLet = letter.ToString().ToUpper();
                var lowerLet = letter.ToString().Insert(1, "- ");
                var buildBothLetters = upperLet + lowerLet;
                upperLowerLetters.Add(buildBothLetters);
                var charStrng = charArr[index];
                index++;
               // Console.WriteLine(upperLet + lowerLet + index);
            }

            var addHyphen = charArr.ToString().Insert(1, "-");

            // Console.WriteLine($"You also said: {addHyphen}");

        }
    }
}

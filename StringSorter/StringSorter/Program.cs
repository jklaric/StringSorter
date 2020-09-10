using System;
using System.Collections.Generic;
using System.Linq;

namespace StringSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = new List<string>();
            var validList = new List<string>();
            var intCheckList = new List<int>();
            var rng = new Random();

            for (int i = 0; inputList.Count < 10; i++)
            {
                Console.WriteLine("Please enter a word.");
                var userInput = Console.ReadLine();

                if (!inputList.Contains(userInput) && !int.TryParse(userInput, out _) && userInput.Length > 1)
                {
                    inputList.Add(userInput);
                }

                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            foreach (var word in inputList)
            {
                if (IsValid(word))
                {
                    validList.Add(word);
                }
            }

            if (validList.Count > 0)
            {
                var shuffledList = validList.OrderBy(a => rng.Next());
                Console.Write(string.Join(" ", shuffledList));
            }
            else
            {
                Console.WriteLine("Not enough valid words...");
            }

            static bool IsValid(string word)
            {
                if (word.StartsWith(word.LastOrDefault()))
                {
                    return true;
                }

                return false;
            }
        }
    }
}

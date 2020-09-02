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
            var shuffleList = new List<string>();
            var intCheckList = new List<int>();

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
                    shuffleList.Add(word);
                }
            }

            for (int i = 0; i < shuffleList.Count - 1; i++)
            {
                Random r = new Random();
                int rInt = r.Next(0, shuffleList.Count - 1);
                
                if (!intCheckList.Contains(rInt))
                {
                    Console.Write(shuffleList[rInt] + " ");
                }

                intCheckList.Add(rInt);
            }
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

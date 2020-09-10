using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StringSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = new List<string>();
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

            var shuffledList = IsValid(inputList).OrderBy(a => rng.Next());
            Console.Write(string.Join(" ", shuffledList));

            static List<string> IsValid(List<string> inputList)
            {
                var validList = new List<string>();

                for (int i = 0; i < inputList.Count - 1; i++)
                {
                    for (int j = 0; j < inputList.Count - 1; j++)
                    {
                        if (inputList[i].StartsWith(inputList[j].LastOrDefault()) && !validList.Contains(inputList[j]))
                        {
                            validList.Add(inputList[j]);
                        }
                    }
                }

                return validList;
            }
        }
    }
}

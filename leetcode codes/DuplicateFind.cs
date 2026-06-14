using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_codes
{
    public class DuplicateFind
    {
        public bool IsValidInput(string input)
        {

            return !string.IsNullOrWhiteSpace(input);
        }

        public Dictionary<char, int> FindDuplicateCounts(string text)
        {

            Dictionary<char, int> charCount = new Dictionary<char, int>();
            Dictionary<char, int> duplicates = new Dictionary<char, int>();

            // Count characters
            foreach (char ch in text)
            {
                if (charCount.ContainsKey(ch))
                {
                    charCount[ch]++;
                }
                else
                {
                    charCount[ch] = 1;
                }
            }

            // Store duplicates with count
            foreach (var item in charCount)
            {
                if (item.Value > 1)
                {
                    duplicates[item.Key] = item.Value;
                }
            }

            return duplicates;
        }
    }



    public class Program
    {
        public static void Main()
        {
            DuplicateFind finder = new DuplicateFind();


            // Create object
            while (true)
            {
                Console.WriteLine("Enter the input:");

                string input = Console.ReadLine();

                if (!finder.IsValidInput(input))
                {
                    Console.WriteLine(
                        "Input cannot be empty. Please enter again.");

                    continue;
                }
                else
                {
                    Dictionary<char, int> result = finder.FindDuplicateCounts(input);

                    // Print output
                    Console.WriteLine("Duplicate characters with count:");

                    foreach (var item in result)
                    {
                        Console.WriteLine(item.Key + " -> " + item.Value);
                    }
                }

                    break;
            }

            // Call method
            

                   //another program to find a area of shape
                    
              
                    AreaFinder shape = new AreaFinder();
                    Console.Write("Enter number of sides: ");
                    int sides = Convert.ToInt32(Console.ReadLine());
                    shape.FindArea(sides);
                
            
        }
    }
}

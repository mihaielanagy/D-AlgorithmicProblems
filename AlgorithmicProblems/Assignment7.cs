using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    internal class Assignment7
    {
        public void Run()
        {
            Console.WriteLine("Please write a few characters:");
            string input = Console.ReadLine();

            char[] characters = input.ToCharArray();

            Console.WriteLine("The characters you have entered are:");
            foreach (char c in characters)
            {
                Console.Write(c + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Please write one character:");
            string charInput = Console.ReadLine();

            bool success;
            char character;
            success = char.TryParse(charInput, out character);

            while (!success)
            {
                Console.WriteLine("Invalid entry.Please write one character:");
                charInput = Console.ReadLine();
                success = char.TryParse(charInput, out character);
            }

            bool isInList = false;

            foreach (char ch in characters)
            {
                if (ch == character)
                {
                    isInList = true;
                    break;
                }
            }

            if (isInList == true)
            {
                Console.WriteLine("Your character is in the list above");
            }
            else
            {
                Console.WriteLine("Your character is not the list above");
            }
        }
    }
}
    

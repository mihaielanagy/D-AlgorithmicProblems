using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    internal class Assignment8
    {
        public void Run()
        {
            Console.WriteLine("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            Console.WriteLine("Please enter a word: ");
            string word = Console.ReadLine();

            if (phrase.Contains(word))
            {
                Console.WriteLine("Your word is in the phrase '" + phrase + "'.");
            }
            else
            {
                Console.WriteLine("Your word is not in the phrase '" + phrase + "'.");
            }
        }
    }
}

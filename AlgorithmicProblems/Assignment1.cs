using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    internal class Assignment1
    {
        public void Run()
        {
            Console.WriteLine("Please enter a number greater than 0: ");
            string input = Console.ReadLine();

            int inputValue;
            bool success = int.TryParse(input, out inputValue);
            bool valid = success && inputValue > 0;

            while (!valid)
            {
                Console.WriteLine("Invalid Input. Try again...");
                Console.Write("Please enter a number greater than 0: ");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue);
                valid = success && inputValue > 0;
            }

            if (inputValue % 2 == 0)
            {
                Console.WriteLine("The entered number is even");
            }
            else
            {
                Console.WriteLine("The entered number is odd");
            }
        }
    }
}

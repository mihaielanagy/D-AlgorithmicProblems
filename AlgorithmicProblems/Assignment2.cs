using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    internal class Assignment2
    {
        public void Run()
        {
            Console.WriteLine("Please enter a number greater than 0: ");
            string input = Console.ReadLine();

            int n;
            bool success = int.TryParse(input, out n);
            bool valid = success && n > 0;

            while (!valid)
            {
                Console.WriteLine("Invalid Input. Try again...");
                Console.Write("Please enter a number greater than 0: ");
                input = Console.ReadLine();
                success = int.TryParse(input, out n);
                valid = success && n > 0;
            }

            int x;
            int sum = 0;
            int product = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter a number greater than 0: ");
                string input2 = Console.ReadLine();
                success = int.TryParse(input2, out x);
                while (!success)
                {
                    Console.WriteLine("Invalid Input. Try again...");
                    Console.Write("Please enter a number greater than 0: ");
                    input2 = Console.ReadLine();
                    success = int.TryParse(input2, out x);
                }
                sum = sum + x;
                product = product * x;

            }

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The product is: {product}");
        }
    }
}

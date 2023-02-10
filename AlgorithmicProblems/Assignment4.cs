using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    internal class Assignment4
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
            int[] array = new int[n];
            int x;

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
                array[i] = x;

            }

            foreach (int i in array)
            {
                Console.WriteLine();
                Console.Write("The number {0} ", i);

                if (i % 2 == 0)
                {
                    Console.Write("is even");
                }
                else
                {
                    Console.Write("is odd");
                }

            }
        }
    }
}

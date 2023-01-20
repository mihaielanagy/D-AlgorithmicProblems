using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    internal class Assignment6
    {
        public void Run()
        {
            List<int> numbers = new List<int>();
            int x;
            int y = 1;
            bool success;

            while (y != 0)
            {
                Console.WriteLine("Please enter an integer number: (enter 0 to stop the reading)");
                string input = Console.ReadLine();
                success = int.TryParse(input, out x);

                while (!success)
                {
                    Console.WriteLine("Invalid Input. Try again...");
                    Console.Write("Please enter an integer number: (enter 0 to stop the reading)");
                    input = Console.ReadLine();
                    success = int.TryParse(input, out x);
                }

                if (x != 0)
                {
                    numbers.Add(x);
                }

                y = x;
            }

            int[] array = numbers.ToArray();
            int i = array.Length;
            int sum = 0;
            int product = 1;

            Console.WriteLine("The sum of the elements in the first half of the array is:");
            for (int j = 0; j < i / 2; j++)
            {
                sum = sum + array[j];
            }
            Console.WriteLine(sum);

            Console.WriteLine("The product of the elements in the second half of the array is:");
            for (int j = i; j > i / 2; j--)
            {
                product = product * array[j - 1];
            }
            Console.WriteLine(product);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    internal class Assignment5
    {
        public void Run()
        {

            List<int> numbers = new List<int>();
            int x;
            int y = 1;
            bool success;

            while (y != 0)
            {
                Console.WriteLine("Please enter an integer number: ");
                string input = Console.ReadLine();
                success = int.TryParse(input, out x);

                while (!success)
                {
                    Console.WriteLine("Invalid Input. Try again...");
                    Console.Write("Please enter an integer number: ");
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
            //int i = array.Length;
            //Console.WriteLine("The array elements, from right to left are:");

            //for (int j = i; j > 0; j--)
            //{
            //    Console.Write(array[j - 1] + ", ");
            //}

            Console.WriteLine("The array elements, from right to left are:");
            foreach (int z in array.Reverse()) 
            {
                Console.Write($"{array[z - 1]}, ");
            }

        }
    }
}

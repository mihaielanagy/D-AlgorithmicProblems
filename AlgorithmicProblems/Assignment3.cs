using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    internal class Assignment3
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

            int[] array1 = new int[n];
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
                array1[i] = x;

            }

            int[] array2 = new int[n]; ;
            int y = 0;

            Console.WriteLine("Array 1:");
            foreach (int i in array1)
            {
                Console.Write("{0} ", i);
                array2[y] = i;
                y++;
            }

            Console.WriteLine(Environment.NewLine + "Array 2:");
            foreach (int i in array2)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}

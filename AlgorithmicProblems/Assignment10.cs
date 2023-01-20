using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    internal class Assignment10
    {
        public void Run()
        {
            Console.WriteLine("Please enter the number of columns for your array:");
            string inputN = Console.ReadLine();
            int n;
            bool successN = int.TryParse(inputN, out n);
            bool valid = successN && n > 0;
            while (!valid)
            {
                Console.WriteLine("Invalid Input. Try again...");
                Console.Write("Please enter the number of columns for your array: ");
                inputN = Console.ReadLine();
                successN = int.TryParse(inputN, out n);
                valid = successN && n > 0;
            }

            Console.WriteLine("Please enter the number of rows for your array:");
            string inputM = Console.ReadLine();
            int m;
            bool successM = int.TryParse(inputM, out m);
            bool validM = successM && n > 0;
            while (!validM)
            {
                Console.WriteLine("Invalid Input. Try again...");
                Console.Write("Please enter the number of rows for your array: ");
                inputM = Console.ReadLine();
                successM = int.TryParse(inputM, out m);
                validM = successM && m > 0;
            }

            int[,] array = new int[m, n];
            int totalEntries = m * n;
            int entryNo = 1;
            string input;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Please enter an integer number: ({entryNo}/{totalEntries} numbers)");
                    input = Console.ReadLine();
                    bool success = int.TryParse(input, out array[i, j]);
                    while (!success)
                    {
                        Console.WriteLine($"Invalid input. Please enter an integer number: ({entryNo}/{totalEntries} numbers)");
                        input = Console.ReadLine();
                        success = int.TryParse(input, out array[i, j]);
                    }
                    entryNo++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Your array is:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[i, j],4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int sumDiagonal = 0;
            int prodDiagonal = 1;
            string arrayDiagonal = "";

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        arrayDiagonal = arrayDiagonal + array[i, j] + ",";
                        sumDiagonal = sumDiagonal + array[i, j];
                        prodDiagonal = prodDiagonal * array[i, j];
                    }
                }
            }

            Console.WriteLine($"The numbers in diagonal are: {arrayDiagonal}");
            Console.WriteLine($"The sum of the numbers in diagonal is: {sumDiagonal}");
            Console.WriteLine($"The product of the numbers in diagonal is: {prodDiagonal}");
        }
    }
}

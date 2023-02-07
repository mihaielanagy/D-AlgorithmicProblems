using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    internal class Assignment10b
    {
        public void Run()
        {
            Console.WriteLine("Please insert the number of rows and columns for your table");
            string inputN = Console.ReadLine();
            int n;
            bool successN = int.TryParse(inputN, out n);
            bool valid = successN && n > 0;
            while (!valid)
            {
                Console.WriteLine("Invalid Input.Please insert the number of rows and columns for your table:");
                inputN = Console.ReadLine();
                successN = int.TryParse(inputN, out n);
                valid = successN && n > 0;
            }

            int[,] array = new int[n, n];
            string input;
            int totalEntries = n * n;
            int entryNo = 1;
            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Please enter an integer number: ({entryNo}/{totalEntries} numbers)");
                    input = Console.ReadLine();
                    bool success = int.TryParse(input, out array[i,j]);
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

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[i, j],4}");
                }
                Console.WriteLine();
            }

            string arrayDiagonal ="";
            int sumDiagonal = 0;
            int prodDiagonal = 1;

            for (int i = 0; i < n; i++)
            {
                arrayDiagonal += array[i, i] + ", ";
                sumDiagonal += array[i,i];
                prodDiagonal *= array[i, i];
            }

            int x = n-1;

            string arrayDiagonal2 = "";
            int sumDiagonal2 = 0;
            int prodDiagonal2 = 1;

            for (int i = 0; i < n; i++)
            {
                arrayDiagonal2 += array[i, x] + ", ";
                sumDiagonal2 += array[i, x];
                prodDiagonal2 *= array[i, x];
                x--;

            }

            Console.WriteLine($"The numbers in the first diagonal are: {arrayDiagonal}");
            Console.WriteLine($"The sum of the numbers in the first diagonal is: {sumDiagonal}");
            Console.WriteLine($"The product of the numbers in the first diagonal is: {prodDiagonal}");
            Console.WriteLine($"The numbers in the second diagonal are: {arrayDiagonal2}");
            Console.WriteLine($"The sum of the numbers in the second diagonal is: {sumDiagonal2}");
            Console.WriteLine($"The product of the numbers in the second diagonal is: {prodDiagonal2}");
        }
        
    }
}

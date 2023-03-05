using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    internal class Assignment14
    {
        //Se dau două şiruri cu elemente numere naturale.
        //Determinaţi câte dintre elementele primului şir
        //sunt mai mari decât toate elementele celui de-al doilea şir.

        public void Run()
        {
            Console.WriteLine("Please insert the number of items to add in the array (n):");
            string inputN = Console.ReadLine();
            int n;
            bool successN = int.TryParse(inputN, out n);
            bool valid = successN && n >= 1 && n <= 100;
            while (!valid)
            {
                Console.WriteLine("Invalid input. Please insert a number between 1 and 100 (n):");
                inputN = Console.ReadLine();
                successN = int.TryParse(inputN, out n);
                valid = successN && n >= 1 && n <= 100;
            }

            int[] arrayN = new int[n];
            string input;
            int entryNo = 1;
            int x;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Please enter an integer number {entryNo}/{n} numbers");
                input = Console.ReadLine();
                bool success = int.TryParse(input, out x);
                valid = success && x >= 1 && x <= 10000;
                while (!valid)
                {
                    Console.WriteLine($"Invalid Input. Please enter an integer number between 1 and 10,000: {entryNo}/{n} numbers ");
                    input = Console.ReadLine();
                    success = int.TryParse(input, out x);
                }
                arrayN[i] = x;
                entryNo++;
            }

            Console.WriteLine("Please insert the number of items to add in the array (m):");
            string inputM = Console.ReadLine();
            int m;
            bool successM = int.TryParse(inputM, out m);
            bool validM = successN && m >= 1 && n <= 100;
            while (!validM)
            {
                Console.WriteLine("Invalid input. Please insert a number between 1 and 100 (m):");
                inputN = Console.ReadLine();
                successM = int.TryParse(inputM, out m);
                validM = successN && m >= 1 && m <= 100;
            }

            int[] arrayM = new int[m];
            entryNo = 1;
            int y;
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Please enter an integer number {entryNo}/{m} numbers");
                input = Console.ReadLine();
                bool success = int.TryParse(input, out y);
                valid = success && y >= 1 && y <= 10000;
                while (!valid)
                {
                    Console.WriteLine($"Invalid Input. Please enter an integer number between 1 and 10,000: {entryNo}/{m} numbers ");
                    input = Console.ReadLine();
                    success = int.TryParse(input, out y);
                }
                arrayM[i] = y;
                entryNo++;
            }

            foreach (int number in arrayN)
            {
                Console.Write($"{number}, ");
            }

            Console.WriteLine();

            foreach (int number in arrayM)
            {
                Console.Write($"{number}, ");
            }

            int countC = 0;
            int C = 0;
            foreach(int number in arrayN)
            {
                countC = 0;
                foreach (int number2 in arrayM)
                {                    
                    if(number > number2)
                    {
                        countC++;
                    }
                }
                if (countC == m)
                {
                    C++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(C);

        }
    }
}

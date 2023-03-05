using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    internal class Assignment13
    {
        //Se citește un vector cu n elemente, numere naturale distincte.
        //Să se afișeze elementele cuprinse între elementul cu valoarea minimă
        //și cel cu valoare maximă din vector, inclusiv acestea.
        public void Run()
        {
            Console.WriteLine("Please insert the number of items for your array.");
            string inputN = Console.ReadLine();
            int n;
            bool successN = int.TryParse(inputN, out n);
            bool valid = successN && n > 0;
            while (!valid)
            {
                Console.WriteLine("Invalid Input.Please insert the number of items for your array (between 1 and 1000):");
                inputN = Console.ReadLine();
                successN = int.TryParse(inputN, out n);
                valid = successN && n > 0;
            }

            int[] array = new int[n];
            string input;
            int entryNo = 1;
            int x;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Please enter an integer number: {entryNo}/{n} numbers");
                input = Console.ReadLine();
                bool success = int.TryParse(input, out x);
                valid = success && x>= 1 && x <= 100000;
                while (!valid)
                {
                    Console.WriteLine($"Invalid Input. Please enter an integer number between 1 and 100,000: {entryNo}/{n} numbers ");
                    input = Console.ReadLine();
                    success = int.TryParse(input, out x);
                }
                array[i] = x;
                entryNo++;
            }

            int minValue = 100000;
            int maxValue = 0;
            int minValueIndex = 0;
            int maxValueIndex = 0;
            
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minValueIndex = i;
                }
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxValueIndex = i;
                }
            }

            int startIndex = minValueIndex;
            int endIndex = maxValueIndex;

            if (minValueIndex > maxValueIndex)
            {
                startIndex = maxValueIndex;
                endIndex = minValueIndex;
            }
            
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write($"{array[i]} ");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicProblems
{
    public class Assignment12
    {
        //Stergere element din vector.
        //Se dă un șir cu n elemente întregi și un număr p.
        //Să se șteargă din șirul X elementul aflat pe poziția p.

        public void Run()
        {
            Console.WriteLine("Please insert the number of items to add in the array (n):");
            string inputN = Console.ReadLine();
            int n;
            bool successN = int.TryParse(inputN, out n);
            bool valid = successN && n >= 1 && n <= 1500;
            while (!valid)
            {
                Console.WriteLine("Invalid input. Please insert a number between 1 and 1500 (n):");
                inputN = Console.ReadLine();
                successN = int.TryParse(inputN, out n);
                valid = successN && n >= 1 && n <= 1500;
            }

            Console.WriteLine($"Please insert the index of the number to be removed from the array (between 1 and {n}):");
            string inputP = Console.ReadLine();
            int p;
            bool successP = int.TryParse(inputP, out p);
            bool validP = successP && p >= 1 && p <= n;
            while (!valid)
            {
                Console.WriteLine($"Invalid Input. Please enter a number between 1 and {n}");
                inputP = Console.ReadLine();
                successP = int.TryParse(inputP, out p);
                validP = successP && p >= 1 && p <= n;
            }

            int[] array = new int[n];
            string input;
            int entryNo = 1;
            int x;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Please enter an integer number {entryNo}/{n} numbers");
                input = Console.ReadLine();                
                bool success = int.TryParse(input, out x);
                valid = success && x >= -1000000 && x <= 1000000;
                while (!valid)
                {
                    Console.WriteLine($"Invalid Input. Please enter an integer number between -1,000,000 and 1,000,000: {entryNo}/{n} numbers ");
                    input = Console.ReadLine();
                    success = int.TryParse(input, out x);
                }
                array[i] = x;
                entryNo++;
            }

            Console.WriteLine();

            int[] array2 = new int[n-1];

            for (int i = 1 ; i < n; i++)
            {
                if (i < p) 
                { 
                    array2[i-1] = array[i-1]; 
                }
                if(i >= p)
                {
                    array2[i-1] = array[i];
                }
                
            }
            Console.WriteLine();

            foreach (int number in array2)
            {
                Console.Write($"{number}, ");
            }

        }


    }
}

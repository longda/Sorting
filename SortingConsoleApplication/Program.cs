using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while (input.ToLower() != "exit")
            {
                Random r = new Random();
                List<int> listToSort = new List<int>();
                Console.WriteLine("Generating list...");

                for (int i = 0; i < r.Next(20); i++)
                {
                    listToSort.Add(r.Next(100));
                }

                PrintList(listToSort);

                Console.WriteLine("");
                Console.WriteLine("Sorting list...");

                listToSort = new List<int>(MergeSort.Sort(listToSort.ToArray()));

                PrintList(listToSort);

                Console.WriteLine("");
                Console.WriteLine("Press any key to run again. Type 'exit' to end program.");
                Console.WriteLine("");
                input = Console.ReadLine();
            }
        }

        private static void PrintList(List<int> input)
        {
            Console.WriteLine("List Contents:");
            input.ForEach(a => Console.Write("{0} ", a.ToString()));
            Console.WriteLine("");
        }
    }
}

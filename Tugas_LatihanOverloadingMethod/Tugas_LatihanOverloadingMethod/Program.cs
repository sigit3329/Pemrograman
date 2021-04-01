using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_LatihanOverloadingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();

            Console.WriteLine($"Minimum #1 : {numbers.FindMinimum(3, 1)}");
            Console.WriteLine($"Minimum #2 : {numbers.FindMinimum(3, 2, 4)}");
            Console.WriteLine();
            Console.WriteLine($"Maximum #1 : {numbers.FindMaximum(3, 1)}");
            Console.WriteLine($"Maximum #2 : {numbers.FindMaximum(3, 2, 4)}");

            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}

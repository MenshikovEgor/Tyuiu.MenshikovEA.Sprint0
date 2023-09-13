using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.MenshikovEA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Sum of array items = " + DataService.AdditionArray(numsArray));

            Console.WriteLine("Difference of array items = " + DataService.SubstractionArray(numsArray));

            Console.WriteLine("Product of array items = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}

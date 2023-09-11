using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.MenshikovEA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition
            Console.WriteLine(DataService.Addition(1, 5));
            //Substruction
            Console.WriteLine(DataService.Substruction(15, 5));
            //Multiplication
            Console.WriteLine(DataService.Multiplication(10, 10));
            //Division
            Console.WriteLine(DataService.Division(5, 5));

            Console.ReadKey();
        }
    }
}

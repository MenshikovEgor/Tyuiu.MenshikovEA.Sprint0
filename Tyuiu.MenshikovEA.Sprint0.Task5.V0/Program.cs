using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.MenshikovEA.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(5, 5));
            Console.WriteLine("A - B = " + DataService.Substruction(25, 5));
            Console.WriteLine("A * B = " + DataService.Addition(5, 5));
            Console.WriteLine("A / B = " + DataService.Division(25, 5));
            Console.ReadKey();
        }
    }
}

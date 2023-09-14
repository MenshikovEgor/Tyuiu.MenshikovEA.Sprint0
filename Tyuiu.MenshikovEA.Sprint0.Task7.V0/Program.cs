using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.MenshikovEA.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sprint #0 / Made by: Menshikov E. A. / ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Sprint #0                                                               *");
            Console.WriteLine("* Topic: creating the final sprint decision                               *");
            Console.WriteLine("* Task #7                                                                 *");
            Console.WriteLine("* Variant #0                                                              *");
            Console.WriteLine("* Made by: Menshikov Egor Aleksandrovich  /  ИИПб-23-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* CONDITION:                                                              *");
            Console.WriteLine("* Write a program that summarizes the value of two arrays                 *");
            Console.WriteLine("* of the same length.                                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* INITIAL DATA:                                                           *");
            Console.WriteLine("***************************************************************************");

            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("The value of the firest array elements");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }

            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("The value of the second array elements");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* RESULT:                                                                 *");
            Console.WriteLine("***************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("The sum of the array elements is equal to:");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Error! The original arrays have a different number of elements.");
            }
            Console.ReadKey();
        }
    }
}

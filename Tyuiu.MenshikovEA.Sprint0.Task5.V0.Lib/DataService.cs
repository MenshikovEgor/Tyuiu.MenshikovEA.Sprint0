﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MenshikovEA.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Substruction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("The second variable can't equals to 0 ");
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}
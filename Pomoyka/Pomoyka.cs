﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomoyka
{
    class Pomoyka
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Enter data");

            a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine());

            c = Convert.ToInt32(Console.ReadLine());

            int d = a + b;

            c -= a + b;

            Console.WriteLine("Result = {0}", d + c);
            Console.ReadKey();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int[3];
            for(int i = 0; i < 1; i++)
            {
                arr[i] = i;
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DishSelection;

namespace Dishs4TheDay
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input: ");
                var displayService = new DisplayService();
                Console.WriteLine(displayService.GetDisplayString(Console.ReadLine()));
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}

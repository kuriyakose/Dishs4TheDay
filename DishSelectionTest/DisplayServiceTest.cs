using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using DishSelection;

namespace DishSelectionTest
{
    [TestFixture]
    public class DisplayServiceTest
    {

        [TestCase("morning, 1, 2, 3", Result = "Output: eggs, toast, coffee")]
        [TestCase("morning, 2, 1, 3", Result = "Output: eggs, toast, coffee")]
        [TestCase("morning, 1, 2, 3, 4", Result = "Output: eggs, toast, coffee, error")]
        [TestCase("morning, 1, 2, 3, 3, 3", Result = "Output: eggs, toast, coffee(x3)")]
        [TestCase("night, 1, 2, 3, 4", Result = "Output: steak, potato, wine, cake")]
        [TestCase("night, 1, 2, 2, 4", Result = "Output: steak, potato(x2), cake")]
        [TestCase("night, 1, 2, 3, 5", Result = "Output: steak, potato, wine, error")]
        [TestCase("night, 1, 1, 2, 3, 5", Result = "Output: steak, error")]
        [TestCase("", Result = "Invalid Input - You must enter a comma delimited list of dish types with at least one selection")]
        [TestCase("xxx, 1, 1, 2, 3, 5", Result = "Output: Wrong time of day")]        
        public string GetDisplayString(string inputString)
        {
            var displayService = new DisplayService();
            return displayService.GetDisplayString(inputString);
        }

    }
}

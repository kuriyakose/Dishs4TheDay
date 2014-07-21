using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using DishSelection;

namespace DishSelectionTest
{
    [TestFixture]
    public class DishServiceTest
    {
        [Test]
        public void GetDish()
        {
            var dishService = new DishService();
            Assert.AreEqual("error", dishService.GetDish(DishConstant.TimeOfDay.Morning, DishConstant.DishType.Dessert).dishName);
        }

        [TestCase(DishConstant.TimeOfDay.Morning, DishConstant.DishType.Entree, Result = "eggs")]
        [TestCase(DishConstant.TimeOfDay.Morning, DishConstant.DishType.Side, Result = "Toast")]
        [TestCase(DishConstant.TimeOfDay.Morning, DishConstant.DishType.Drink, Result = "coffee")]
        [TestCase(DishConstant.TimeOfDay.Morning, DishConstant.DishType.Dessert, Result = "error")]
        [TestCase(DishConstant.TimeOfDay.Night, DishConstant.DishType.Entree, Result = "steak")]
        [TestCase(DishConstant.TimeOfDay.Night, DishConstant.DishType.Side, Result = "potato")]
        [TestCase(DishConstant.TimeOfDay.Night, DishConstant.DishType.Drink, Result = "wine")]
        [TestCase(DishConstant.TimeOfDay.Night, DishConstant.DishType.Dessert, Result = "cake")]
        public string GetDish(DishConstant.TimeOfDay timeOfDay, DishConstant.DishType dishType)
        {
            var dishService = new DishService();
            return dishService.GetDish(timeOfDay, dishType).dishName;
        }
    }
}

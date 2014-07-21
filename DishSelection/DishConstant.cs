using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DishSelection
{
    public class DishConstant
    {
        public enum DishType
        {
            Entree = 1,
            Side,
            Drink,
            Dessert
        };

        public enum TimeOfDay
        {
            Morning = 0,
            Night
        };
    }
}

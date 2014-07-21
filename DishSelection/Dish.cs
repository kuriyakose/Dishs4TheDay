using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DishSelection
{
    public class Dish
    {
        public DishConstant.DishType dishType;
        public DishConstant.TimeOfDay TimeOfDay;
        public string dishName;

        public Dish() 
        { }

        public Dish(DishConstant.DishType dishType, DishConstant.TimeOfDay timeOfDay, string dishName)
        {
            this.dishType = dishType;
            this.TimeOfDay = timeOfDay;
            this.dishName = dishName;
        }
    }
}

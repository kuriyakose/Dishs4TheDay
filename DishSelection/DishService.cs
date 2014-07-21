using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DishSelection
{
    public class DishService : IDishService
    {
        Dishes dishes = new Dishes();

        // Get the Dish for Time Of Day with Dish Type
        public Dish GetDish(DishConstant.TimeOfDay timeOfDay, DishConstant.DishType dishType)
        {
            if (dishes != null)
            {
                var dish = dishes.DishList.FirstOrDefault(x => x.dishType == dishType && x.TimeOfDay == timeOfDay);
                if (dish == null)
                {
                    dish = new Dish();
                    dish.dishName = "error";
                }
                return dish;
            }

            var dish1 = new Dish();
            dish1.dishName = "error";
            return dish1;
        }
    }
}

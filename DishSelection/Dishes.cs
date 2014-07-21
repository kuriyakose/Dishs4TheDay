using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DishSelection
{
    public class Dishes
    {
        public IList<Dish> DishList;

        public Dishes() {
            DishList = new List<Dish>();
            DishList.Add(new Dish(DishConstant.DishType.Entree, DishConstant.TimeOfDay.Morning, "eggs"));
            DishList.Add(new Dish(DishConstant.DishType.Entree, DishConstant.TimeOfDay.Night, "steak"));
            DishList.Add(new Dish(DishConstant.DishType.Side, DishConstant.TimeOfDay.Morning, "Toast"));
            DishList.Add(new Dish(DishConstant.DishType.Side, DishConstant.TimeOfDay.Night, "potato"));
            DishList.Add(new Dish(DishConstant.DishType.Drink, DishConstant.TimeOfDay.Morning, "coffee"));
            DishList.Add(new Dish(DishConstant.DishType.Drink, DishConstant.TimeOfDay.Night, "wine"));
            //DishList.Add(new Dish(DishConstant.DishType.Dessert, DishConstant.TimeOfDay.Morning, "Not Applicable"));
            DishList.Add(new Dish(DishConstant.DishType.Dessert, DishConstant.TimeOfDay.Night, "cake"));
        }

    }
}

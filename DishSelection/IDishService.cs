using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DishSelection
{
    public interface IDishService
    {
        Dish GetDish(DishConstant.TimeOfDay timeOfDay, DishConstant.DishType dishType);
    }
}

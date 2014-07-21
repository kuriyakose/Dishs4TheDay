using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DishSelection
{
    public class DisplayService : IDisplayService
    {
        private IDishService dishService;


        public DisplayService()
        {
            this.dishService = new DishService();
        }

        public DisplayService(IDishService dishService)
        {
            this.dishService = dishService;
        }

        public void Display(string dishName) 
        {
            Console.Write(dishName);
        }

        // Get the Dishes for Output
        public string GetDisplayString(string inputString)
        {
            string[] inputArray = inputString.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder displayString = new StringBuilder();
            int count = inputArray.Count();
            if (count <= 0)
            {
                displayString.Append("Invalid Input - You must enter a comma delimited list of dish types with at least one selection");
                return displayString.ToString();
            }

            displayString.Append("Output: ");
            var timeOfDay = DishConstant.TimeOfDay.Morning;
            if (inputArray[0] == "night")
                timeOfDay = DishConstant.TimeOfDay.Night;
            else if (inputArray[0].ToLower() == "morning")
            {
            }
            else
            {
                displayString.Append("Wrong time of day");
                return displayString.ToString();
            }

            var inputArrayList = inputArray.ToList();
            inputArrayList.RemoveAt(0);
            inputArrayList.Sort();
            inputArray = inputArrayList.Distinct().ToArray();
            count = inputArray.Count();

            for (var i = 0; i < count; ++i)
            {
                var dish = dishService.GetDish(timeOfDay, (DishConstant.DishType)int.Parse(inputArray[i]));
                var displayService = new DisplayService();
                displayString.Append(dish.dishName.ToLower());
                var sel = inputArrayList.Where(x => x == inputArray[i]);
                if (sel.Count() > 1)
                {
                    if (timeOfDay == DishConstant.TimeOfDay.Morning && DishConstant.DishType.Drink == (DishConstant.DishType)int.Parse(inputArray[i])
                        || (timeOfDay == DishConstant.TimeOfDay.Night && DishConstant.DishType.Side == (DishConstant.DishType)int.Parse(inputArray[i]))
                        )
                    {
                        displayString.Append(string.Format("(x{0})", sel.Count()));
                        displayString.Append((i != count - 1 ? ", " : ""));
                    }
                    else
                    {
                        displayString.Append((i != count - 1 ? ", " : ""));
                        displayString.Append("error");
                        return displayString.ToString();
                    }
                }
                else
                {
                    displayString.Append((i != count - 1 ? ", " : ""));
                }
            }

            return displayString.ToString();
        }
    }
}

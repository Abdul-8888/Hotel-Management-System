using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.BL
{
    public class Food
    {
        private int foodId;
        private string dishName;
        private int price;

        public int FoodId { get => foodId; set => foodId = value; }
        public string DishName { get => dishName; set => dishName = value; }
        public int Price { get => price; set => price = value; }
    
        public Food(int foodId, string dishName, int price)
        {
            FoodId = foodId;
            DishName = dishName;
            Price = price;
        }

        public Food(string dishName, int price)
        {
            DishName = dishName;
            Price = price;
        }

    }
}

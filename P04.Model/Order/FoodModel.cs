using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Model.Order
{
    public class FoodModel
    {
        public int FoodId { get; set; }

        public string FoodName { get; set; }

        public string FoodDescription { get; set; }

        public decimal Price { get; set; }

        public int FoodScore { get; set; }

        public string SimpleFactory { get; set; }

        public string Customer { get; set; }

    }
}

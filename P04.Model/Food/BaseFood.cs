﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Model.Order;

namespace P04.Model
{
    public class BaseFood
    {
        #region Basic properties

        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string FoodDescription { get; set; }
        public string CookMethod { get; set; }
        public decimal Price { get; set; }
        public ConsoleColor MessageColor { get; set; }

        public string CustomerName { get; set; }

        #endregion

        public OrderModel CustomerOrder { get; set; }

        public BaseFood()
        {
            CustomerOrder = OrderInfoList.CreateInstance()._orderModel;
        }






    }
}

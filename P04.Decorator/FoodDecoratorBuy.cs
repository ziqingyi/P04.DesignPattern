using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Model;

namespace P04.Decorator
{
    public class FoodDecoratorBuy:BaseFoodDecorator
    {
        public FoodDecoratorBuy(AbstractFood food) : base(food)
        {
            Console.WriteLine("Food Decorator Buy constructor");
        }

        public override void Cook()
        {
            Console.WriteLine("Cook Food");
            base.Cook();
        }

    }
}

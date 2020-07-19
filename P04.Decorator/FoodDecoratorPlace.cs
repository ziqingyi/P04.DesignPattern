using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Model;

namespace P04.Decorator
{
    public class FoodDecoratorPlace:BaseFoodDecorator
    {
        public FoodDecoratorPlace(AbstractFood food) : base(food)
        {
            Console.WriteLine("Food Decorator Place constructor");
        }

        public override void Cook()
        {
            base.Cook();
            Console.WriteLine("Place");
        }
    }
}

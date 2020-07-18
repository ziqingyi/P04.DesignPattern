using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Model;

namespace P04.Decorator
{
    public class FoodDecoratorShow:BaseFoodDecorator
    {
        public FoodDecoratorShow(AbstractFood food) : base(food)
        {
            Console.WriteLine("Food Decorator Show constructor");
        }

        public override void Cook()
        {
            Console.WriteLine("Show");
            base.Cook();
        }


    }
}

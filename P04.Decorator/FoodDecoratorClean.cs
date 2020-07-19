using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Model;

namespace P04.Decorator
{
    public class FoodDecoratorClean: BaseFoodDecorator
    {
        public FoodDecoratorClean(AbstractFood food) : base(food)
        {
            Console.WriteLine("Food Decorator Clean constructor");
        }

        public override void Cook()
        {
            
            Console.WriteLine("Clean");
            base.Cook();
        }


    }
}

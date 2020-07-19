using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Model;

namespace P04.Decorator
{
    public class FoodDecoratorCut:BaseFoodDecorator
    {
        public FoodDecoratorCut(AbstractFood food) : base(food)
        {
            Console.WriteLine("Food Decorator Cut constructor");
        }

        public override void Cook()
        {
            Console.WriteLine("Cut");
            base.Cook();
            
        }

    }
}

using P04.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Decorator
{
    public class BaseFoodDecorator :AbstractFood
    {
        private AbstractFood _food = null;

        public BaseFoodDecorator(AbstractFood food)
        {
            this._food = food;
        }

        public override void Cook()
        {
            Console.WriteLine("base");
            this._food.Cook();
        }


    }
}

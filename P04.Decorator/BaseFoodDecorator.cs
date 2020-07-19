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

        public BaseFoodDecorator(AbstractFood food):base()
        {
            this._food = food;
        }

        public override void Cook()
        {
            //Console.WriteLine("base");//should not add more logic
            this._food.Cook();
        }


    }
}

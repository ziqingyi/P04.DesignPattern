using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Helper;

namespace P04.Model
{
    public abstract class AbstractFood
    {
        public BaseFood BaseFood { get; set; }

        public AbstractFood()
        {

        }

        public AbstractFood(string configPath)
        {
            // read from path and convert string to object
            this.BaseFood = JsonHelper.JsonFileToObject<BaseFood>(configPath);
        }

        public abstract void Cook();





    }
}

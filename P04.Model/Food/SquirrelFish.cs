using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Helper;

namespace P04.Model.Food
{
    public class SquirrelFish:AbstractFood
    {
        public SquirrelFish() : base("Config/SquirrelFish.json")
        {

        }

        public override void Cook()
        {
            string cookMsg = string.Format("Now chief is cooking, your dish is : {0}", this.BaseFood.FoodName);
            LogHelper.WriteInfoLog(cookMsg,this.BaseFood.MessageColor);
        }


    }
}

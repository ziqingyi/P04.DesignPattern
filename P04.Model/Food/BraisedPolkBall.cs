using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Helper;

namespace P04.Model.Food
{
    public class BraisedPolkBall:AbstractFood
    {
        public BraisedPolkBall() : base("Config/BraisedPolkBall.json")
        {

        }

        public override void Cook()
        {
            String des = string.Format("Now chief is cooking, your dish is : {0}", this.BaseFood.FoodName);
            LogHelper.WriteInfoLog(des, this.BaseFood.MessageColor);
        }
    }
}

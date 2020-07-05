using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Helper;

namespace P04.Model.Food
{
    public class CrabPackage: AbstractFood
    {
        public CrabPackage() : base("Config/CrabPackage.json")
        {

        }

        public override void Cook()
        {
            string cookMsg = string.Format("Now chief is cooking, your dish is : {0}", BaseFood.FoodName);
            LogHelper.WriteInfoLog(cookMsg,this.BaseFood.MessageColor);
        }


    }
}

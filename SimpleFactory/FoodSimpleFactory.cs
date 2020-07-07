using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using P04.Model;
using P04.Model.Enum;
using P04.Model.Food;

namespace SimpleFactory
{
    public class FoodSimpleFactory
    {
        public static AbstractFood CreateInstanceByNormal(FoodTypeEnum foodType)
        {
            switch (foodType)
            {
                case FoodTypeEnum.BraisedPolkBall:
                    return new BraisedPolkBall();
                case FoodTypeEnum.CrabPackage:
                    return new CrabPackage();
                case FoodTypeEnum.SquirrelFish:
                    return new SquirrelFish();
                case FoodTypeEnum.VegetarianEel:
                    return new VegetarianEel();
                case FoodTypeEnum.ThreeNestedDuck:
                    return new ThreeNestedDuck();
                default:
                    throw new Exception("Sorry, no such dish...");
                //return null;
            }

        }

        // create food obj by reading from config file. 
        public static string AbstractFoodType = ConfigurationManager.AppSettings["AbstractFoodType"];
        public static AbstractFood CreateInstanceByConfig()
        {
            FoodTypeEnum foodType = (FoodTypeEnum)Enum.Parse(typeof(FoodTypeEnum), AbstractFoodType);

            return CreateInstanceByNormal(foodType);
        }

















    }
}

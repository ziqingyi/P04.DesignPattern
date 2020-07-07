using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
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

        // create by config files and reflections
        private static readonly string AbstractFoodTypeReflection = ConfigurationManager.AppSettings["AbstractFoodTypeReflection"];
        public static AbstractFood CreateInstanceByReflection()
        {
            Assembly assembly = Assembly.Load(AbstractFoodTypeReflection.Split(',')[1]);
            Type type = assembly.GetType(AbstractFoodTypeReflection.Split(',')[0]);
            AbstractFood result = (AbstractFood) Activator.CreateInstance(type);
            return result;
        }


        // create by string dll information

        public static AbstractFood CreateInstanceByReflectionInfo(string typeDll)
        {
            Assembly assembly = Assembly.Load(typeDll.Split(',')[1]);
            Type type = assembly.GetType(typeDll.Split(',')[0]);
            AbstractFood result = (AbstractFood)Activator.CreateInstance(type);
            return result;
        }










    }
}

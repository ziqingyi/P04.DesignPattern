using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using P04.Model;
using P04.Model.Enum;
using P04.Model.Food;

namespace P04.SimpleFactory
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
                    //it's better to throw exception rather than handle null value
                    //because it's better to show error where it happens
            }

        }

        // create food obj by reading from config file.then convert to Enum, then use simple way to create instance 
        public static string AbstractFoodType = ConfigurationManager.AppSettings["AbstractFoodType"];
        public static AbstractFood CreateInstanceByConfig()
        {
            FoodTypeEnum foodType = (FoodTypeEnum)Enum.Parse(typeof(FoodTypeEnum), AbstractFoodType);

            return CreateInstanceByNormal(foodType);
        }

        // read config files (get DLLand class information) and create by reflections
        private static readonly string AbstractFoodTypeReflection = ConfigurationManager.AppSettings["AbstractFoodTypeReflection"];
        public static AbstractFood CreateInstanceByReflection()
        {
            Assembly assembly = Assembly.Load(AbstractFoodTypeReflection.Split(',')[1]);
            Type type = assembly.GetType(AbstractFoodTypeReflection.Split(',')[0]);
            AbstractFood result = (AbstractFood)Activator.CreateInstance(type);
            return result;
        }

        // create by receiving string dll information, then create by reflection
        public static AbstractFood CreateInstanceByReflectionInfo(string typeDll)
        {
            Assembly assembly = Assembly.Load(typeDll.Split(',')[1]);
            Type type = assembly.GetType(typeDll.Split(',')[0]);
            AbstractFood result = (AbstractFood)Activator.CreateInstance(type);
            return result;
        }




    }
}

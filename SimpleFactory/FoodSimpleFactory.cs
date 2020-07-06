﻿using System;
using System.Collections.Generic;
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





    }
}
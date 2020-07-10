using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Interface;
using P04.Model;
using P04.Model.Food;
using P04.Model.Soup;

namespace P04.AbstractFactory
{
    public class HuaiYangFoodAbstractFactory: IHuaiYangFoodAbstractFactory
    {
        public AbstractFood CreateBraisedPolkBall()
        {
            return new BraisedPolkBall();
        }

        public AbstractFood CreateCrabPackage()
        {
            return new CrabPackage();
        }

        public AbstractFood CreateSquirrelFish()
        {
            return new SquirrelFish();
        }

        public AbstractSoup CreateTomatoEggSoup()
        {
            return new TomatoEggSoup();
        }

        public AbstractSoup CreateHotSourSoup()
        {
            return new HotSourSoup();
        }

        public AbstractSoup CreatePorkRibsSoup()
        {
            return new PorkRibsSoup();
        }
    }
}

using P04.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Model.Soup;

namespace P04.Interface
{
    public interface IHuaiYangFoodAbstractFactory
    {
        AbstractFood CreateBraisedPolkBall();
        AbstractFood CreateCrabPackage();
        AbstractFood CreateSquirrelFish();

        AbstractSoup CreateTomatoEggSoup();
        AbstractSoup CreateHotSourSoup();
        AbstractSoup CreatePorkRibsSoup();

    }
}

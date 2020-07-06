using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Model.Food;

namespace P04.Model.Enum
{
    public enum FoodTypeEnum
    {
        [Description("Des: Braised Polk Ball")]
        BraisedPolkBall,

        [Description("Des: Crab Package")]
        CrabPackage,

        [Description("Des: Squirrel Fish")]
        SquirrelFish,

        [Description("Des: Vegetarian Eel")]
        VegetarianEel,

        [Description("Des: Three Nested Duck")]
        ThreeNestedDuck
    }
}

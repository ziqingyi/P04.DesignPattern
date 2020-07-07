using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Model;
using P04.Model.Enum;
using P04.Model.Food;
using P04.SimpleFactory;

namespace P04.DesignPattern
{
    class Program
    {
        #region Global Params
        private static object _orderObj = new object();
        #endregion


        static void Main(string[] args)
        {
            {
                //#region normal pattern of program 
                //Console.WriteLine("*********************1 normal pattern of program****************");
                //AbstractFood braisedPolkBall = new BraisedPolkBall();
                //braisedPolkBall.ShowBasicInfo();
                //braisedPolkBall.ShowCookMethod();
                //braisedPolkBall.Taste();

                //AbstractFood crabPackage = new CrabPackage();
                //crabPackage.ShowBasicInfo();
                //crabPackage.ShowCookMethod();
                //crabPackage.Taste();

                //AbstractFood squirrelFish = new SquirrelFish();
                //squirrelFish.ShowBasicInfo();
                //squirrelFish.ShowCookMethod();
                //squirrelFish.Taste();
                //Console.WriteLine("********************* End Of normal Pattern*******************************");
                //#endregion
            }
            {
                #region simple factory
                Console.WriteLine("*********************2 simple factory****************");
                AbstractFood braisedPolkBall = FoodSimpleFactory.CreateInstanceByNormal(FoodTypeEnum.BraisedPolkBall);
                if (braisedPolkBall == null)
                {

                }
                else
                {
                    braisedPolkBall.ShowBasicInfo();
                    braisedPolkBall.ShowCookMethod();
                    braisedPolkBall.Taste();
                }



                Console.WriteLine("********************* End Of simple factory*******************************");
                #endregion

            }
        }
    }
}

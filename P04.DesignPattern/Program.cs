using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.FactoryMethod;
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
                Console.WriteLine("*********************2 simple factory, create instance with Enum****************");
                Console.WriteLine("******simple factory: create instance based on Enum, call different new Class() ");
                AbstractFood braisedPolkBall = FoodSimpleFactory.CreateInstanceByNormal(FoodTypeEnum.BraisedPolkBall);
                
                braisedPolkBall.ShowBasicInfo();
                braisedPolkBall.ShowCookMethod();
                braisedPolkBall.Taste();

                Console.WriteLine("************create instance from Config, then to Enum, then use simple factory ");
                AbstractFood crabPackage = FoodSimpleFactory.CreateInstanceByConfig();
                crabPackage.ShowBasicInfo();
                crabPackage.ShowBasicInfo();
                crabPackage.Taste();

                Console.WriteLine("************create instance from Config, then use reflection to create class ");
                AbstractFood squirrelFish = FoodSimpleFactory.CreateInstanceByReflection();
                squirrelFish.ShowBasicInfo();
                squirrelFish.ShowCookMethod();
                squirrelFish.Taste();

                Console.WriteLine("********************* End Of simple factory*******************************");
                #endregion
            }
            {
                #region Factory Method

                Console.WriteLine("**********************3 Factory Method*************************************");
                BaseFactory braisedPolkBallFactory = new BraisedPolkBallFactory();
                AbstractFood braisedPolkBall =  braisedPolkBallFactory.CreateInstance();
                braisedPolkBall.ShowBasicInfo();
                braisedPolkBall.ShowCookMethod();
                braisedPolkBall.Taste();

                Console.WriteLine("**********************End of Factory Method*************************************");

                #endregion



            }




        }
    }
}

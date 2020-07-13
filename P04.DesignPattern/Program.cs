using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using P04.AbstractFactory;
using P04.FactoryMethod;
using P04.Helper;
using P04.Interface;
using P04.Model;
using P04.Model.Enum;
using P04.Model.Food;
using P04.Model.Order;
using P04.Model.Soup;
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
            {
                #region Abstract Factory 
                Console.WriteLine("**********************4 Abstract Factory*************************************");
                IHuaiYangFoodAbstractFactory factory = new HuaiYangFoodAbstractFactory();
                Console.WriteLine("1 first dish");
                AbstractFood food = factory.CreateBraisedPolkBall();
                food.ShowBasicInfo();
                food.ShowCookMethod();
                food.Taste();

                Console.WriteLine("2 a soup");
                AbstractSoup soup = factory.CreateTomatoEggSoup();
                soup.ShowBasicInfo();
                soup.Taste();

                Console.WriteLine("**********************End of Abstract Factory*************************************");

                #endregion
            }
            {
                Console.WriteLine("**********************5 Console Menu*************************************");
                Console.WriteLine("*****************************************************");
                FoodMenu menu = FoodMenu.CreateInstance();
                if (menu.FoodList != null && menu.FoodList.Count > 0)
                {
                    foreach (FoodModel model in menu.FoodList)
                    {
                        Console.WriteLine(string.Format("ID: {0}{1}  Price: {2} Score: {3} ",
                           model.FoodId,
                           model.FoodName,
                           string.Format("{0:C}",model.Price),
                           model.FoodScore
                           )  );
                        Console.WriteLine("*****************************************************");
                    }

                }

                Console.WriteLine("please type in food id and press enter to continue...");
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out int input))
                    {
                        LogHelper.WriteInfoLog("your input is not int, please try again", ConsoleColor.Red);
                    }
                    else
                    {
                        var selectedFood = menu.FoodList.FirstOrDefault(c => c.FoodId == input);
                        if (selectedFood == null)
                        {
                            LogHelper.WriteInfoLog("Sorry, we don't have that!",ConsoleColor.Red);
                        }
                        else
                        {
                            


                        }



                    }




                }



                Console.WriteLine("**********************End of Console Menu*************************************");
            }




            Console.ReadKey();
        }
    }
}

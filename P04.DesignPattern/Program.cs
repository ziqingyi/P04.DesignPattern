using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using P04.AbstractFactory;
using P04.Decorator;
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
            #region normal pattern of program 
            {
                
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
            }
            #endregion
            #region simple factory
            {
                //Console.WriteLine("*********************2 simple factory, create instance with Enum****************");
                //Console.WriteLine("******simple factory: create instance based on Enum, call different new Class() ");
                //AbstractFood braisedPolkBall = FoodSimpleFactory.CreateInstanceByNormal(FoodTypeEnum.BraisedPolkBall);
                
                //braisedPolkBall.ShowBasicInfo();
                //braisedPolkBall.ShowCookMethod();
                //braisedPolkBall.Taste();

                //Console.WriteLine("************create instance from Config, then to Enum, then use simple factory ");
                //AbstractFood crabPackage = FoodSimpleFactory.CreateInstanceByConfig();
                //crabPackage.ShowBasicInfo();
                //crabPackage.ShowBasicInfo();
                //crabPackage.Taste();

                //Console.WriteLine("************create instance from Config, then use reflection to create class ");
                //AbstractFood squirrelFish = FoodSimpleFactory.CreateInstanceByReflection();
                //squirrelFish.ShowBasicInfo();
                //squirrelFish.ShowCookMethod();
                //squirrelFish.Taste();

                //Console.WriteLine("********************* End Of simple factory*******************************");
            }
            #endregion
            #region Factory Method
            {
                //Console.WriteLine("**********************3 Factory Method*************************************");
                //BaseFactory braisedPolkBallFactory = new BraisedPolkBallFactory();
                //AbstractFood braisedPolkBall =  braisedPolkBallFactory.CreateInstance();
                //braisedPolkBall.ShowBasicInfo();
                //braisedPolkBall.ShowCookMethod();
                //braisedPolkBall.Taste();
                //Console.WriteLine("**********************End of Factory Method*************************************");
            }
            #endregion
            #region Abstract Factory 
            {
                //Console.WriteLine("**********************4 Abstract Factory*************************************");
                //IHuaiYangFoodAbstractFactory factory = new HuaiYangFoodAbstractFactory();
                //Console.WriteLine("1 first dish");
                //AbstractFood food = factory.CreateBraisedPolkBall();
                //food.ShowBasicInfo();
                //food.ShowCookMethod();
                //food.Taste();

                //Console.WriteLine("2 a soup");
                //AbstractSoup soup = factory.CreateTomatoEggSoup();
                //soup.ShowBasicInfo();
                //soup.Taste();

                //Console.WriteLine("**********************End of Abstract Factory*************************************");
            }
            #endregion
            #region Console Menu
            {
                //Console.WriteLine("**********************5 Console Menu*************************************");
                //Console.WriteLine("*****************************************************");
                //FoodMenu menu = FoodMenu.CreateInstance();
                //if (menu.FoodList != null && menu.FoodList.Count > 0)
                //{
                //    foreach (FoodModel model in menu.FoodList)
                //    {
                //        Console.WriteLine(string.Format("ID: {0}{1}  Price: {2} Score: {3} ",
                //           model.FoodId,
                //           model.FoodName,
                //           string.Format("{0:C}",model.Price),
                //           model.FoodScore
                //           )  );
                //        Console.WriteLine("*****************************************************");
                //    }

                //}

                //Console.WriteLine("please type in food id and press enter to continue...");
                //while (true)
                //{
                //    if (!int.TryParse(Console.ReadLine(), out int input))
                //    {
                //        LogHelper.WriteInfoLog("your input is not int, please try again", ConsoleColor.Red);
                //    }
                //    else
                //    {
                //        var selectedFood = menu.FoodList.FirstOrDefault(c => c.FoodId == input);
                //        if (selectedFood == null)
                //        {
                //            LogHelper.WriteInfoLog("Sorry, we don't have that!",ConsoleColor.Red);
                //        }
                //        else
                //        {
                //            string msg = string.Format("You select dish: {0}, price: {1}, Score: {2}, price: {3}",
                //                selectedFood.FoodId,
                //                selectedFood.FoodName,
                //                selectedFood.FoodScore,
                //                string.Format("{0:C}",selectedFood.Price )

                //            );
                //            LogHelper.WriteInfoLog(msg, ConsoleColor.DarkGreen);
                //            AbstractFood absFood = FoodSimpleFactory.CreateInstanceByReflectionInfo(selectedFood.SimpleFactory);
                //            absFood.ShowBasicInfo();
                //            absFood.ShowCookMethod();
                //            break;
                //        }
                //    }
                //}
                //Console.WriteLine("**********************End of Console Menu*************************************");
            }
            #endregion






            #region Single-thread order
            /*
             {
                 Console.WriteLine("******************Single-thead order***************************");
                 char[] tips = "Please see below".ToCharArray();
                 for (int i = 0; i < tips.Length; i++)
                 {
                     Console.Write(tips[i]);
                     Thread.Sleep(100);
                 }

                 Console.WriteLine();

                 FoodMenu menu = FoodMenu.CreateInstance();

                 OrderInfoList orderInfoList = OrderInfoList.CreateInstance();
                 OrderModel order = orderInfoList._orderModel;
                 string msg1 = string.Format("{0} come to order. ", string.Join(", ", order.CustomerList));
                 LogHelper.WriteInfoLog(msg1, ConsoleColor.DarkRed);


                 //List<Task> taskList = new List<Task>();
                 Dictionary<string, Dictionary<AbstractFood, int>> dictionaryAll =
                     new Dictionary<string, Dictionary<AbstractFood, int>>();

                 List<Dictionary<AbstractFood, int>> allCustomerScoreDicList = new List<Dictionary<AbstractFood, int>>();
                 foreach (var item in order.CustomerList)
                 {
                     allCustomerScoreDicList.Add(new Dictionary<AbstractFood, int>());
                 }

                 int k = 0;
                 foreach (string customer in order.CustomerList)
                 {
                     Dictionary<AbstractFood, int> oneCustomerScoreDic = allCustomerScoreDicList[k++];


                     //taskList.Add(
                     //    Task.Run(
                     //        () =>
                     {
                         List<FoodModel> orderList = menu.GetFoodListByRandom();
                         string orderMsg = string.Format("Customer: {0} order these: {1}", customer,
                             string.Join(",", orderList.Select(c => c.FoodName)));
                         LogHelper.WriteInfoLog(orderMsg, ConsoleColor.DarkRed);

                         foreach (FoodModel food in orderList)
                         {
                             AbstractFood foodChosen =
                                 FoodSimpleFactory.CreateInstanceByReflectionInfo(food.SimpleFactory);
                             foodChosen.BaseFood.CustomerName = customer;
                             foodChosen.Cook();
                             foodChosen.Taste();
                             int score = foodChosen.Score();
                             oneCustomerScoreDic.Add(foodChosen, score);
                         }

                         int maxScore = oneCustomerScoreDic.Values.Max();
                         foreach (var item in oneCustomerScoreDic.Where(d => d.Value == maxScore))
                         {
                             Console.BackgroundColor = ConsoleColor.DarkRed;
                             Console.WriteLine(
                                 $"@@@@@@{customer} 's favourite food is {item.Key.BaseFood.FoodName}" +
                                 $", score is {item.Value} @@@@@@");
                             Console.BackgroundColor = ConsoleColor.Black;
                         }



                     }
                   //     )
                  //         );
                 }

                 //Task.WaitAll(taskList.ToArray());
                 Console.WriteLine("*****************All Customers' favourite*********************************");
                 int maxAll = allCustomerScoreDicList.Max(d => d.Values.Max());
                 for (int i = 0; i < order.CustomerList.Count; i++)
                 {
                     var dic = allCustomerScoreDicList[i];
                     foreach (var item in dic.Where(d => d.Value == maxAll))
                     {
                         Console.WriteLine($"{order.CustomerList[i]} " +
                                           $"s favourite food is {item.Key.BaseFood.FoodName}" +
                                           $", score is {item.Value}");
                     }
                 }
             }
             #endregion



             #region multi-thread order
             {
                 Console.WriteLine("******************Multi-thead order***************************");
                 char[] tips = "Please see below".ToCharArray();
                 for (int i = 0; i < tips.Length; i++)
                 {
                     Console.Write(tips[i]);
                     Thread.Sleep(100);
                 }

                 Console.WriteLine();

                 FoodMenu menu = FoodMenu.CreateInstance();

                 OrderInfoList orderInfoList = OrderInfoList.CreateInstance();
                 OrderModel order = orderInfoList._orderModel;
                 string msg1 = string.Format("{0} come to order. ", string.Join(", ", order.CustomerList));
                 LogHelper.WriteInfoLog(msg1, ConsoleColor.DarkRed);


                 List<Task> taskList = new List<Task>();
                 Dictionary<string, Dictionary<AbstractFood, int>> dictionaryAll =
                     new Dictionary<string, Dictionary<AbstractFood, int>>();

                 List<Dictionary<AbstractFood, int>> allCustomerScoreDicList = new List<Dictionary<AbstractFood, int>>();
                 //must have a container containing multiple containers for each customer.
                 //if use multi-thread, sharing one container will cause issue, lock will affect efficiency.
                 //so must use separate container for each thread.
                 foreach (var item in order.CustomerList)
                 {
                     allCustomerScoreDicList.Add(new Dictionary<AbstractFood, int>());
                 }

                 int k = 0;
                 foreach (string customer in order.CustomerList)
                 {
                     Dictionary<AbstractFood, int> oneCustomerScoreDic = allCustomerScoreDicList[k++];


                     taskList.Add(
                         Task.Run(
                             () =>
                             {
                                 List<FoodModel> orderList = menu.GetFoodListByRandom();
                                 string orderMsg = string.Format("Customer: {0} order these: {1}", customer,
                                     string.Join(",", orderList.Select(c => c.FoodName)));
                                 LogHelper.WriteInfoLog(orderMsg, ConsoleColor.DarkRed);

                                 foreach (FoodModel food in orderList)
                                 {
                                     AbstractFood foodChosen =
                                         FoodSimpleFactory.CreateInstanceByReflectionInfo(food.SimpleFactory);
                                     foodChosen.BaseFood.CustomerName = customer;
                                     foodChosen.Cook();
                                     foodChosen.Taste();
                                     int score = foodChosen.Score();
                                     oneCustomerScoreDic.Add(foodChosen, score);
                                 }

                                 int maxScore = oneCustomerScoreDic.Values.Max();
                                 foreach (var item in oneCustomerScoreDic.Where(d => d.Value == maxScore))
                                 {
                                     Console.BackgroundColor = ConsoleColor.DarkRed;
                                     Console.WriteLine(
                                         $"@@@@@@{customer} 's favourite food is {item.Key.BaseFood.FoodName}" +
                                         $", score is {item.Value} @@@@@@");
                                     Console.BackgroundColor = ConsoleColor.Black;
                                 }
                             }
                         )
                     );
                 }

                 Task.WaitAll(taskList.ToArray()); // wait for every task finish eating. 
                 Console.WriteLine("*****************All Customers' favourite*********************************");
                 int maxAll = allCustomerScoreDicList.Max(d => d.Values.Max());
                 for (int i = 0; i < order.CustomerList.Count; i++)
                 {
                     var dic = allCustomerScoreDicList[i];
                     foreach (var item in dic.Where(d => d.Value == maxAll))
                     {
                         Console.WriteLine($"{order.CustomerList[i]} " +
                                           $"s favourite food is {item.Key.BaseFood.FoodName}" +
                                           $", score is {item.Value}");
                     }
                 }
             }
          */
            #endregion

            #region decorator
            /*
             {
                    Console.WriteLine("**********************Decorator************************************");
                    AbstractFood food = FoodSimpleFactory.CreateInstanceByNormal(FoodTypeEnum.BraisedPolkBall);

                    //do before base.Cook();
                    food = new FoodDecoratorCut(food);
                    food = new FoodDecoratorClean(food);


                    //do after base.Cook();
                    food = new FoodDecoratorPlace(food);
                    food = new FoodDecoratorShow(food);




                    //do before base.Cook();
                    //even put at the end, execute before base.Cook()
                    food = new FoodDecoratorBuy(food);

                    food.Cook();
            }
            */
            #endregion

            #region observer

            {
                AbstractFood food = FoodSimpleFactory.CreateInstanceByNormal(FoodTypeEnum.BraisedPolkBall);
                food.PerfactScoreHandle += () =>
                {
                    Console.WriteLine("Customer buy....");
                };

                food.PerfactScoreHandle += () => { Console.WriteLine("Journalist1 report....."); };

                food.PerfactScoreHandle += () => { Console.WriteLine("Journalist2 report......"); };

                food.Score(5);

            }


            #endregion







            Console.ReadKey();
        }
    }
}

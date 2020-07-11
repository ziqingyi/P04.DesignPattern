using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Helper;

namespace P04.Model.Order
{
    public sealed class FoodMenu
    {
        private volatile static FoodMenu _foodMenu = null;

        private static readonly object _lockHelper = new object();

        private FoodMenu() { }

        public List<FoodModel> FoodList = new List<FoodModel>();

        public static FoodMenu CreateInstance()
        {
            if (_foodMenu == null)
            {
                lock (_lockHelper)
                {
                    if (_foodMenu == null)
                    {
                        // _foodMenu = new FoodMenu();//simple initialization

                        //create FoodList from XML file
                        // read from XML file first, then Deserialize file to FoodModelList
                        string xmlPath = ConfigurationManager.AppSettings["XmlFoodPath"];
                       if(string.IsNullOrWhiteSpace(xmlPath))
                           throw new Exception("please config the XML path in config file, node name is : XmlFoodPath ");

                       xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, xmlPath);

                       if(File.Exists(xmlPath))
                           throw new Exception(string.Format("config file: {0} does not exist", xmlPath));

                       FoodModelList _foodModelList = XmlHelper.FileToObject<FoodModelList>(xmlPath);

                       if(_foodModelList == null)
                        throw new Exception("failed to load information");

                       _foodMenu = new FoodMenu()
                       {
                           FoodList =  _foodModelList.FoodList
                       };

                    }
                }
            }

            return _foodMenu;
            //must return FoodMenu, not food list. Singleton is return unique instance of the class.
        }



        //randomly return some food based on ID
        public List<FoodModel> GetFoodListByRandom(int takeNum = 5)
        {
            var foodlist = FoodList.Select(a => new {a, newID = Guid.NewGuid()}).OrderBy(b => b.newID);
            if (takeNum > 0)
            {
                return foodlist.Take(takeNum).Select(c => c.a).ToList();
            }
            else
            {
                return foodlist.Select(c => c.a).ToList();
            }

        }




    }
}

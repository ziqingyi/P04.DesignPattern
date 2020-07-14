using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Helper;

namespace P04.Model.Order
{
    public sealed class OrderInfoList
    {
        public OrderModel _orderModel = null;

        private volatile static OrderInfoList _instance = null;
        private static readonly object _lockHelper = new object();
        private OrderInfoList() { }

        public static OrderInfoList CreateInstance()
        {
            if (_instance == null)
            {
                lock (_lockHelper)
                {
                    if (_instance == null)
                    {
                        string xmlPath = ConfigurationManager.AppSettings["XmlConfigPath"];
                        if(string.IsNullOrWhiteSpace(xmlPath))
                            throw new Exception("please config xml file, node name: XmlConfigPath");
                        xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, xmlPath);

                        if(!File.Exists(xmlPath))
                            throw new Exception(string.Format("config file: {0} not exist", xmlPath));
                        _instance._orderModel = XmlHelper.FileToObject<OrderModel>(xmlPath);

                        if (_instance == null)
                        {
                            throw new Exception("Does not read config files successfully");
                        }
                    }
                }
            }
            return _instance;
        }

    }
}

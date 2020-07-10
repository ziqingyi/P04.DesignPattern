using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Helper;

namespace P04.Model.Soup
{
    public abstract class AbstractSoup
    {
        public BaseSoup baseSoup { get; set; }

        public AbstractSoup(string configPath)
        {
            baseSoup = JsonHelper.JsonFileToObject<BaseSoup>(configPath);
        }

        public void ShowBasicInfo()
        {
            LogHelper.WriteInfoLog(string.Format(" ID: {0} ", baseSoup.SoupId), baseSoup.MessageColor);
            LogHelper.WriteInfoLog(string.Format("Soup Name: {0}", baseSoup.SoupName), baseSoup.MessageColor);
            LogHelper.WriteInfoLog(string.Format("Soup Description: {0}", baseSoup.SoupDescription),baseSoup.MessageColor);
        }

        public void Taste()
        {
            LogHelper.WriteInfoLog(string.Format("Customer is eating Soup: {0}", baseSoup.SoupName), baseSoup.MessageColor);
        }


    }
}

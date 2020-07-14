using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P04.Helper;

namespace P04.Model
{
    public abstract class AbstractFood
    {
        public BaseFood BaseFood { get; set; }

        public AbstractFood()
        {

        }

        public AbstractFood(string configPath)
        {
            // read from path and convert string to object
            this.BaseFood = JsonHelper.JsonFileToObject<BaseFood>(configPath);
        }

        public abstract void Cook();

        #region output methods

        public void ShowBasicInfo()
        {
            LogHelper.WriteInfoLog(string.Format("Food Id is: {0}", this.BaseFood.FoodId), this.BaseFood.MessageColor);
            LogHelper.WriteInfoLog(string.Format("Food Name is : {0}", this.BaseFood.FoodName), this.BaseFood.MessageColor);
            LogHelper.WriteInfoLog(string.Format("Food Description: {0}", this.BaseFood.FoodDescription), this.BaseFood.MessageColor);
        }

        public void ShowCookMethod()
        {
            LogHelper.WriteInfoLog(string.Format("Cooking Method: {0}", this.BaseFood.CookMethod), this.BaseFood.MessageColor);
        }
        public void Taste()
        {
            string CustomerName = string.IsNullOrEmpty(this.BaseFood.CustomerName) ? "" : this.BaseFood.CustomerName;
            LogHelper.WriteInfoLog(string.Format("Customer: {0} is tasting {1}",CustomerName, this.BaseFood.FoodName ), this.BaseFood.MessageColor);
        }
        #endregion





        public virtual int Score(int i = 0)
        {
            int scoreNum = i == 0 ? new Random(DateTime.Now.Millisecond).Next(1, 6) : i;
            string ScoreMsg = this.BaseFood.CustomerOrder.FoodScoreMessage[scoreNum - 1];
            string message1 = string.Format(BaseFood.CustomerOrder.ScoreMessage, this.BaseFood.CustomerName,
                this.BaseFood.FoodName, string.Format(ScoreMsg, scoreNum));
            LogHelper.WriteInfoLog(message1);

            return scoreNum;
        }

        public event Action PerfactScoreHandle;
        protected virtual void OnPerfactScoreHandle(int score)
        {
            if(score == 5 && this.PerfactScoreHandle(!=null))
            {
                this.PerfactScoreHandle.Invoke();
            }
        }



    }
}

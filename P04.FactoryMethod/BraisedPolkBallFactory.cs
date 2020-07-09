using P04.Model;
using P04.Model.Food;

namespace P04.FactoryMethod
{
    public class BraisedPolkBallFactory : BaseFactory
    {
        public override AbstractFood CreateInstance()
        {
            return new BraisedPolkBall();
        }
    }
}

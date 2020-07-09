using P04.Model;

namespace P04.FactoryMethod
{
    public abstract class BaseFactory
    {
        public abstract AbstractFood CreateInstance();
    }
}

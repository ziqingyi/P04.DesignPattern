using P04.Model;
using P04.Model.Food;

namespace P04.FactoryMethod
{
    public class CrabPackageFactory : BaseFactory
    {
        public override AbstractFood CreateInstance()
        {
            return new CrabPackage();
        }

    }
}

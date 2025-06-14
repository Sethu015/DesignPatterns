namespace AbstractFactory
{
    //Concrete Factory
    public class ModernVersionFactory : IShowVersionFactory
    {
        public IAndroid ShowAndroid()
        {
            return new ModernAndroid();
        }

        public IIos ShowIos()
        {
            return new NewIPhone();
        }
    }
}

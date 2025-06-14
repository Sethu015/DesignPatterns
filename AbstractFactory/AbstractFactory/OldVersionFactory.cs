namespace AbstractFactory
{
    //Concrete Factory
    public class OldVersionFactory : IShowVersionFactory
    {
        public IAndroid ShowAndroid()
        {
            return new OldAndroid();
        }

        public IIos ShowIos()
        {
            return new OldIPhone();
        }
    }
}

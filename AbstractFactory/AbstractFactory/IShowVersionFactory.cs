namespace AbstractFactory
{
    //Abstract Factory
    public interface IShowVersionFactory
    {
        IAndroid ShowAndroid();
        IIos ShowIos();
    }
}

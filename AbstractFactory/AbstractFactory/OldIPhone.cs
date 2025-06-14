namespace AbstractFactory
{
    //Concrete Product
    public class OldIPhone : IIos
    {
        public void ShowIos()
        {
            Console.WriteLine("This is Older Version of IOS");
        }
    }
}

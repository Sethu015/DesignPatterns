namespace AbstractFactory
{
    //Concrete Product
    public class NewIPhone : IIos
    {
        public void ShowIos()
        {
            Console.WriteLine("This is Newer Version of IOS");
        }
    }
}

namespace AbstractFactory
{
    //Concrete Product
    public class OldAndroid : IAndroid
    {
        public void ShowAndroid()
        {
            Console.WriteLine("This is Older Version of Android");
        }
    }
}

namespace AbstractFactory
{
    //Concrete Product
    public class ModernAndroid : IAndroid
    {
        public void ShowAndroid()
        {
            Console.WriteLine("This is Newer Version of Android");
        }
    }
}

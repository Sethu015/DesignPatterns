namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> Instance = new Lazy<Singleton>(() =>  new Singleton());
        private static int Counter = 0;

        private Singleton()
        {
            Counter++;
            Console.WriteLine($"Counter {Counter}");
        }

        public static Singleton GetInstance()
        {
            return Instance.Value;
        }

        public void DisplayMessage( string message)
        {
            Console.WriteLine( message );
        }
    }
}

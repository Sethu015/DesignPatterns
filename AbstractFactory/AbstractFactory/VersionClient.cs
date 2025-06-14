namespace AbstractFactory
{
    public class VersionClient
    {
        private readonly IShowVersionFactory showVersionFactory;

        public VersionClient(IShowVersionFactory showVersionFactory)
        {
            this.showVersionFactory = showVersionFactory;
        }

        public void ShowVersion()
        {
            showVersionFactory.ShowAndroid().ShowAndroid();
            showVersionFactory.ShowIos().ShowIos();
        }
    }
}

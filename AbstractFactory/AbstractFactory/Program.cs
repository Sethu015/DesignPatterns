using AbstractFactory;

IShowVersionFactory showVersionFactory = new ModernVersionFactory();
var client = new VersionClient(showVersionFactory);
client.ShowVersion();
Console.ReadLine();

using Singleton;

var sing1 = Singleton.Singleton.GetInstance();
sing1.DisplayMessage("Hello");

var sing2 = Singleton.Singleton.GetInstance();
sing2.DisplayMessage("Hi");

Console.ReadLine();
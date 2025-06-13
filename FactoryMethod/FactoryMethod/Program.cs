using FactoryMethod;

IHeaderAndFooter headerAndFooter = FormatFactory.DecideFormat("EXCEL");
Console.WriteLine(headerAndFooter.CreateFooter());
Console.WriteLine(headerAndFooter.CreateHeader());
Console.ReadLine();

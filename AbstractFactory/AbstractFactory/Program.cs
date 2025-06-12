using AbstractFactory;

string format = "Pdf";
FormatProvider provider;
if(format == "Pdf")
{
    provider = new PdfFormat();
}
else
{
    provider = new ExcelFormat();
}
Console.WriteLine(provider.Header.Header);
Console.WriteLine(provider.Footer.Footer);
Console.ReadLine();

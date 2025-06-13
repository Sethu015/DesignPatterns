namespace FactoryMethod
{
    public class ExcelFormat : IHeaderAndFooter
    {
        public string CreateFooter()
        {
            return "Excel Footer";
        }

        public string CreateHeader()
        {
            return "Excel Header";
        }
    }
}

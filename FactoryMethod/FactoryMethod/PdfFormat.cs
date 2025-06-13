namespace FactoryMethod
{
    public class PdfFormat : IHeaderAndFooter
    {
        public string CreateFooter()
        {
            return "PDF Footer";
        }

        public string CreateHeader()
        {
            return "PDF Header";
        }
    }
}

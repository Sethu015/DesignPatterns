namespace FactoryMethod
{
    public static class FormatFactory
    {
        public static IHeaderAndFooter DecideFormat(string format)
        {
            if (format == "PDF")
            {
                return new PdfFormat();
            }
            if(format == "EXCEL")
            {
                return new ExcelFormat();
            }
            throw new ArgumentException("Invalid Format Type");
        }
    }
}

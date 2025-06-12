namespace AbstractFactory
{
    public class PdfFormat : FormatProvider
    {
        public override HeaderProvider Header { get => new PdfHeaderProvider(); set => base.Header = value; }
        public override FooterProvider Footer { get => new PdfFooterProvider(); set => base.Footer = value; }
    }
    public class PdfHeaderProvider : HeaderProvider
    {
        public override string Header { get => "PDF Header"; set => base.Header = "PDF Header"; }
    }
    public class PdfFooterProvider : FooterProvider
    {
        public override string Footer { get => "PDF Footer"; set => base.Footer = "PDF Footer"; }
    }
}

namespace AbstractFactory
{
    public class ExcelFormat : FormatProvider
    {
        public override HeaderProvider Header { get => new ExcelHeaderProvider(); set => base.Header = value; }
        public override FooterProvider Footer { get => new ExcelFooterProvider(); set => base.Footer = value; }
    }
    public class ExcelHeaderProvider : HeaderProvider
    {
        public override string Header { get => "Excel Format"; set => base.Header = "Excel Header"; }
    }
    public class ExcelFooterProvider : FooterProvider
    {
        public override string Footer { get => "Excel Format"; set => base.Footer = "Excel Footer"; }
    }
}

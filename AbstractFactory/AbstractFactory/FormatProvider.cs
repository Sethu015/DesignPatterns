namespace AbstractFactory
{
    public abstract class FormatProvider
    {
        public virtual HeaderProvider Header {  get; set; }
        public virtual FooterProvider Footer { get; set; }
    }
}

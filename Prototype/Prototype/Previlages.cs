namespace Prototype
{
    //object type class used in User to be deep copied
    public class Previlages
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public Previlages Clone()
        {
            return (Previlages)this.MemberwiseClone();
        }
    }
}

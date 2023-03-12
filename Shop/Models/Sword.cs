namespace Shop.Models
{
    public class Sword : BaseShopModel
    {
        public Sword(string name, decimal price, double strength) : base(name, price)
        {
            this.Strength = strength;
        }

        public double Strength { get; set; }
    }
}

namespace Shop.Models
{
    public class Potion : BaseShopModel
    {
        public Potion(string name, decimal price, double HP) : base(name, price)
        {
            this.HP = HP;
        }
        public double HP { get; set; }
    }
}

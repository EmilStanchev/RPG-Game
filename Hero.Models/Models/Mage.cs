namespace Heroes.Models
{
    public class Mage : BaseHero
    {
        public Mage(string name) : base(name)
        {
            this.Strength = 85;
            this.HP = 110;
        }
    }
}

namespace Heroes.Models
{
    public class Archer : BaseHero
    {
        public Archer(string name) : base(name)
        {
            this.Strength = 35;
            this.HP = 90;
        }
    }
}

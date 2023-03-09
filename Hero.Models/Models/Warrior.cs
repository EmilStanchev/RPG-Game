namespace Heroes.Models
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {
            this.Strength = 170;
            this.HP = 40;
        }
    }
}

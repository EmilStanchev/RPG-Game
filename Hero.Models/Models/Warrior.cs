namespace Heroes.Models
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {
            this.Strength = 40;
            this.HP = 170;
        }
    }
}

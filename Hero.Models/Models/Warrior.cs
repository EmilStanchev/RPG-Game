namespace Heroes.Models
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {
            this.Strength = 15;
            this.HP = 170;
        }
    }
}

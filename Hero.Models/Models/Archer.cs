namespace Heroes.Models
{
    public class Archer : BaseHero
    {
        private double _maxStrength { get; set; } = 5;
        private double _maxHP { get; set; } = 90;

        public Archer(string name) : base(name)
        {
            this.Strength = _maxStrength;
            this.HP = _maxHP;
        }

    }
}

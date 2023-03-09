namespace Interfaces.HeroInterfaces
{
    public interface IBaseHero
    {
        public string Name { get; set; }
        public double Strength { get; set; }
        public double HP { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public decimal Money { get; set; }

    }
}

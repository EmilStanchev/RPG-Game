namespace Interfaces.MonsterInterfaces
{
    public interface IBaseMonster
    {

        public string Name { get; set; }
        public double Strength { get; set; }
        public double HP { get; set; }
        public decimal Profit { get; set; }
        public int GivenExperience { get; set; }

    }
}

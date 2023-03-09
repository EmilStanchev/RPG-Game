using Interfaces.MonsterInterfaces;

namespace Monsters.Models
{
    public class Monster : IBaseMonster
    {
        public Monster(string name, double strength, double hP, decimal profit, int givenExperience)
        {
            this.Name = name;
            this.Strength = strength;
            this.HP = hP;
            this.Profit = profit;
            this.GivenExperience = givenExperience;
        }

        public string Name { get; set; }
        public double Strength { get; set; }
        public double HP { get; set; }
        public decimal Profit { get; set; }
        public int GivenExperience { get; set; }

    }
}

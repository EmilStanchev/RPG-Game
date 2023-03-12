using Heroes.HeroActions;
using Interfaces.HeroInterfaces;

namespace Heroes.Models
{
    public class BaseHero : IBaseHero
    {
        public BaseHero(string name)
        {
            this.Name = name;
            this.Experience = 0;
            this.Money = 0;
            this.Level = 1;
        }
        public string Name { get; set; }
        public virtual double Strength { get; set; }
        public virtual double HP { get; set; }
        public virtual int Experience { get; set; }
        public virtual int Level { get; set; }
        public virtual decimal Money { get; set; }
        public void CheckInfoForHero(BaseHero hero)
        {
            HeroAction.CheckInfoForHero(hero);
        }
        public void GetSmallPotion(BaseHero hero)
        {
            HeroAction.GetSmallPotion(hero);
        }
        public void GetMediumPotion(BaseHero hero)
        {
            HeroAction.GetMediumPotion(hero);
        }
        public void GetBigPotion(BaseHero hero)
        {
            HeroAction.GetBigPotion(hero);
        }
        private void CheckHP(BaseHero hero)
        {

        }

    }
}

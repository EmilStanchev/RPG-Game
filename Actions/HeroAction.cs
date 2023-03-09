using Heroes.Models;
using Monsters.Models;

namespace Actions
{
    public static class HeroAction
    {
        public static void Attack(BaseHero hero, Monster monster)
        {
            while (hero.HP >= 0 || monster.HP >= 0)
            {
                hero.HP -= monster.Strength;
                monster.HP -= hero.Strength;
            }
            if (hero.HP > monster.HP)
            {
                Console.WriteLine($"{hero.Name} won and win {monster.GivenExperience} experience and {monster.Profit} gold!");
            }
            else
            {
                Console.WriteLine($"{monster.Name} won!");
            }
        }
        public static void CheckInfoForHero(BaseHero hero)
        {
            Console.WriteLine($"Hero with name: {hero.Name} has {hero.Experience} experience points, {hero.Money} gold" +
                $", and he is {hero.Level} level.");
        }
        public static void GetSmallPotion(BaseHero hero)
        {
            hero.Money -= 18;
            hero.HP += 25;
        }
        public static void GetMediumPotion(BaseHero hero)
        {
            hero.Money -= 22;
            hero.HP += 35;
        }
        public static void GetBigPotion(BaseHero hero)
        {
            hero.Money -= 40;
            hero.HP += 55;
        }
    }
}

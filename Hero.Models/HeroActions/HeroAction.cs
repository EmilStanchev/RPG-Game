using Heroes.Models;
using Monsters.Models;

namespace Heroes.HeroActions
{
    public static class HeroAction
    {
        public static void Attack(BaseHero hero, Monster monster)
        {
            while (hero.HP >= 0 && monster.HP >= 0)
            {
                monster.HP -= hero.Strength;
                Console.WriteLine($"{monster.Name} attack {hero.Name} for {monster.Strength}");
                hero.HP -= monster.Strength;
                Console.WriteLine($"{hero.Name} attack {monster.Name} for {hero.Strength}");

            }
            if (hero.HP > monster.HP)
            {
                Console.WriteLine($"{hero.Name} won and win {monster.GivenExperience} experience and {monster.Profit} gold!" +
                    $"And he has {hero.HP} hp");
                hero.Experience += monster.GivenExperience;
                hero.Money += monster.Profit;
            }
            else
            {
                Console.WriteLine($"{monster.Name} won!");
            }
        }
        public static void CheckInfoForHero(BaseHero hero)
        {
            Console.WriteLine($"Hero with name: {hero.Name} has {hero.Experience} experience points, {hero.Money} gold" +
                $", and he is {hero.Level} level. He has {hero.HP} HP");
        }
        public static void GetSmallPotion(BaseHero hero)
        {
            if (hero.Money >= 18)
            {
                hero.Money -= 18;
                hero.HP += 25;
            }
            else
            {
                Console.WriteLine("You don`t have enough money");
            }
        }
        public static void GetMediumPotion(BaseHero hero)
        {
            if (hero.Money >= 22)
            {
                hero.Money -= 22;
                hero.HP += 35;
            }
            else
            {
                Console.WriteLine("You don`t have enough money");
            }
        }
        public static void GetBigPotion(BaseHero hero)
        {
            if (hero.Money >= 40)
            {
                hero.Money -= 40;
                hero.HP += 55;
            }
            else
            {
                Console.WriteLine("You don`t have enough money");
            }
        }
    }
}

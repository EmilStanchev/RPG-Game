using Heroes.Models;
using Monsters.Models;
using Shop.Models;

namespace Heroes.HeroActions
{
    public static class HeroAction
    {
        public static void Attack(BaseHero hero, Monster monster)
        {
            while (hero.HP >= 0 && monster.HP >= 0)
            {
                monster.HP -= hero.Strength;
                hero.HP -= monster.Strength;
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
                Console.WriteLine($"{monster.Name} won!And you lost the game. You can try again. Restart the game");
                Environment.Exit(0);

            }
        }
        public static void CheckInfoForHero(BaseHero hero)
        {
            Console.WriteLine($"Hero with name: {hero.Name} has {hero.Experience} experience points, {hero.Money} gold" +
                $", and he is {hero.Level} level. He has {hero.HP} HP");
        }
        public static void BuyPotion(BaseHero hero, Potion potion)
        {
            if (CheckMoney(hero, potion))
            {
                hero.Money -= potion.Price;
                hero.HP += potion.HP;
            }
            else
            {
                Console.WriteLine("You don`t have enough money");
            }
        }
        private static bool CheckMoney(BaseHero hero, BaseShopModel shopModel)
        {
            if (hero.Money >= shopModel.Price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

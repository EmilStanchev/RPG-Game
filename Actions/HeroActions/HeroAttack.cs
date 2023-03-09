using Heroes.Models;
using Monsters.Models;

namespace Actions.HeroActions
{
    public class HeroAttack
    {
        public void Attack(BaseHero hero, Monster monster)
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
    }
}

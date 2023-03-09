using Heroes.Models;
using Monsters.Models;

namespace Actions
{
    public static class StorageAction
    {
        public static List<Monster> CreatingMonster()
        {
            Monster rat = new Monster("Rat", 5, 12, 13, 4);
            Monster wolf = new Monster("Wolf", 10, 17, 16, 7);
            Monster bear = new Monster("Bear", 16, 22, 22, 10);
            Monster druid = new Monster("Druid", 19, 28, 28, 14);
            Monster snake = new Monster("Snake", 23, 34, 33, 19);
            Monster dragon = new Monster("Dragon", 76, 230, 66, 40);
            List<Monster> monsters = new List<Monster>() { rat, wolf, bear, druid, snake, dragon };
            return monsters;
        }
        public static List<BaseHero> Heroes(List<BaseHero> heroes)
        {
            return heroes;
        }
    }
}

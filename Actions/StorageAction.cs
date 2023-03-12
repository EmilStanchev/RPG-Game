using Monsters.Models;
using Shop.Models;

namespace Actions
{
    public static class StorageAction
    {
        public static List<Monster> AllMonsters()
        {
            var result = CreatingMonster();
            return result.ToList();
        }
        private static List<Monster> CreatingMonster()
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
        public static List<Sword> AllSwords()
        {
            var result = CreateSwords();
            return result.ToList();
        }
        private static List<Sword> CreateSwords()
        {

            Sword stoneSword = new Sword("Stone Sword", 22, 4);
            Sword elfSword = new Sword("Elf Sword", 52, 9);
            Sword dwarfSword = new Sword("Dwarf Sword", 202, 19);
            List<Sword> swords = new List<Sword>() { stoneSword, elfSword, dwarfSword };
            return swords;
        }
        public static List<Potion> AllPotions()
        {
            var result = CreatePotions();
            return result.ToList();
        }
        private static List<Potion> CreatePotions()
        {

            Potion smallPotion = new Potion("Small potion", 18, 15);
            Potion mediumPotion = new Potion("Medium potion", 25, 23);
            Potion bigPotion = new Potion("Big potion", 60, 54);

            List<Potion> swords = new List<Potion>() { smallPotion, mediumPotion, bigPotion };
            return swords;
        }
    }
}

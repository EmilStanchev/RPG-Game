using Heroes.HeroActions;
using Heroes.Models;
using Monsters.Models;
using Storages;

namespace RPG_Game
{
    public static class UserChoice
    {
        public static Dictionary<int, string> Choices = new Dictionary<int, string>();

        public static int PickOption(int maxValue)
        {
            int input = 0;
            bool isItCorrect = false;
            while (isItCorrect == false)
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                    isItCorrect = false;
                    Console.WriteLine(input);
                    if (input >= 0 && input <= maxValue)
                    {
                        isItCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Option can be from 1 to 3");
                        input = int.Parse(Console.ReadLine());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Option can be from 1 to 3");
                }
            }
            return input;
        }
        public static BaseHero FirstOption(int option)
        {
            while (option != 1)
            {
                switch (option)
                {
                    case 2:
                        StartMenu.Tutorial();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
                StartMenu.StartMenuText();
                option = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if (option == 1)
            {
                Console.WriteLine("Pick your hero name. It should be at least 3 symbols");
                string name = Console.ReadLine();
                bool isItCorrect = CheckHeroName(name);
                BaseHero hero = CreateHero(name, isItCorrect);
                return hero;
            }
            return null;
        }
        public static BaseHero ChooseClass(int option, BaseHero hero)
        {
            switch (option)
            {
                case 1:
                    hero = new Mage(hero.Name);
                    break;
                case 2:
                    hero = new Warrior(hero.Name);
                    break;
                case 3:
                    hero = new Archer(hero.Name);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
            HeroStorage.Heroes.Add(hero);
            return hero;
        }
        public static void Gameplay(int option, BaseHero hero)
        {
            while (option != 6)
            {

                switch (option)
                {
                    case 1:
                        StartMenu.Attack();
                        option = PickOption(5);
                        var monster = GetTheMonster(option);
                        HeroAction.Attack(hero, monster);
                        break;
                    case 2:
                        HeroAction.GetSmallPotion(hero);
                        break;
                    case 3:
                        HeroAction.GetMediumPotion(hero);
                        break;
                    case 4:
                        HeroAction.GetBigPotion(hero);
                        break;
                    case 5:
                        HeroAction.CheckInfoForHero(hero);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
                StartMenu.GameplayText();
                option = int.Parse(Console.ReadLine());

            }
            Console.Clear();
        }
        private static Monster GetTheMonster(int option)
        {

            switch (option)
            {
                case 1:
                    var currentMonster = MonsterStorage.Monsters.SingleOrDefault(m => m.Name == "Rat");
                    return currentMonster;
                case 2:
                    currentMonster = MonsterStorage.Monsters.SingleOrDefault(m => m.Name == "Wolf");
                    return currentMonster;
                case 3:
                    currentMonster = MonsterStorage.Monsters.SingleOrDefault(m => m.Name == "Bear");
                    return currentMonster;
                case 4:
                    currentMonster = MonsterStorage.Monsters.SingleOrDefault(m => m.Name == "Dragon");
                    return currentMonster;
                case 5:
                    Environment.Exit(0);
                    break;
            }
            return null;
        }
        private static bool CheckHeroName(string name)
        {
            if (name.Count() >= 3 && !HeroStorage.Heroes.Any(u => u.Name == name))
            {
                return true;
            }
            else if (HeroStorage.Heroes.Any(u => u.Name == name))
            {
                Console.WriteLine("This name is already taken pick another name");
                return false;
            }
            return false;
        }
        private static BaseHero CreateHero(string name, bool isItCorrect)
        {
            while (isItCorrect == false)
            {
                if (CheckHeroName(name) == true)
                {
                    isItCorrect = true;
                }
                else
                {
                    Console.WriteLine("The name should have at least 3 symbols. ");
                    name = Console.ReadLine();
                }
            }
            if (isItCorrect == true)
            {
                BaseHero hero = new BaseHero(name);
                Console.WriteLine("it enters in the if");
                return hero;
            }
            return null;
        }

    }
}

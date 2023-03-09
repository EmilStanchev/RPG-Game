using Heroes.Models;
using Storages;

namespace RPG_Game
{
    public static class UserChoice
    {
        public static Dictionary<int, string> Choices = new Dictionary<int, string>();

        public static int PickOption()
        {
            int input = 0;
            try
            {
                bool isItCorrect = false;
                input = int.Parse(Console.ReadLine());
                while (isItCorrect == false)
                {
                    if (input >= 1 && input <= 3)
                    {
                        isItCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Option can be from 1 to 3");
                        input = int.Parse(Console.ReadLine());
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Option can be from 1 to 3");
                input = int.Parse(Console.ReadLine());
            }
            return input;
        }
        public static BaseHero FirstOption(int option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("Pick your hero name. It should be at least 3 symbols");
                    string name = Console.ReadLine();
                    bool isItCorrect = CheckHeroName(name);
                    BaseHero hero = CreateHero(name, isItCorrect);
                    return hero;
                case 2:
                    StartMenu.Tutorial();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
            return null;
        }
        public static void ChooseClass(int option, BaseHero hero)
        {
            Console.WriteLine("HP before the trasnofrmation" + hero.HP);
            switch (option)
            {
                case 1:
                    hero = new Mage(hero.Name);
                    Console.WriteLine(hero.HP);
                    break;
                case 2:
                    hero = new Warrior(hero.Name);
                    Console.WriteLine(hero.HP);
                    break;
                case 3:
                    hero = new Archer(hero.Name);
                    Console.WriteLine(hero.HP);
                    break;
            }
            HeroStorage.Heroes.Add(hero);
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

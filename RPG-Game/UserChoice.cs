using Heroes.Models;
using Storages;

namespace RPG_Game
{
    public static class UserChoice
    {
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
        public static void FirstOption(int option)
        {
            //Check(option);
            switch (option)
            {
                case 1:
                    Console.WriteLine("Pick your hero name. It should be at least 3 symbols");
                    string name = Console.ReadLine();
                    var hero = CreateHero(name, CheckHeroName(name));
                    break;
                case 2:
                    StartMenu.Tutorial();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
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
                if (CheckHeroName(name))
                {
                    BaseHero hero = new BaseHero(name);
                    HeroStorage.Heroes.Add(hero);
                    isItCorrect = true;
                    return hero;
                }
                else
                {
                    Console.WriteLine("The name should have at least 3 symbols. ");
                    name = Console.ReadLine();
                }
            }
            return null;
        }

    }
}

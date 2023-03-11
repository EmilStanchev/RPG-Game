namespace RPG_Game
{
    public static class StartMenu
    {
        public static void StartMenuText()
        {
            Console.WriteLine("Welcome to the King`s Bounty!");
            Console.WriteLine("Select one option:");
            Console.WriteLine("1: Create hero");
            Console.WriteLine("2. Show me tutorial");
            Console.WriteLine("3. Exit");
        }
        public static void Tutorial()
        {
            Console.WriteLine("The King`s Bounty is RPG console game. First you should join in our community. To do this you should " +
            "choose option '1' from the previous menu. You should pick your hero name. After that you should pick your hero class." +
            "The classes are: Mage, Warrior and Archer. The Warrior has a lot of HP (health points) but his strenght is not that much." +
            "The Mage has a strentgh but he doesn`t have a lot of HP. The Archer is in the middle of previous two. After you choose the class" +
            "You can attack monsters by choosing option. If you beat them u will recieve experience points and gold. With each level" +
            "your hero HP and Strenght will increase. If you beat all the monster u win. Have fun and don`t leave without give the" +
            "head of the last monster. Good luck and watch out.");
        }
        public static void ChooseClassText()
        {
            Console.WriteLine("Welcome to the King`s Bounty!");
            Console.WriteLine("Select one option:");
            Console.WriteLine("1: Mage");
            Console.WriteLine("2. Warrior");
            Console.WriteLine("3. Archer");
            Console.WriteLine("4. Exit");
        }
        public static void GameplayText()
        {
            Console.WriteLine("Select one option:");
            Console.WriteLine("1: Attack");
            Console.WriteLine("2. Get small potion");
            Console.WriteLine("3. Get medium potion");
            Console.WriteLine("4. Get big potion");
            Console.WriteLine("5. Show hero info");
            Console.WriteLine("6. Exit");

        }
        public static void Attack()
        {
            Console.WriteLine("Attack:");
            Console.WriteLine("1: Rat");
            Console.WriteLine("2. Wolf");
            Console.WriteLine("3. Bear");
            Console.WriteLine("4. Dragon");
            Console.WriteLine("5. Exit");

        }
    }
}

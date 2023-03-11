// See https://aka.ms/new-console-template for more information

using Heroes.Models;
using RPG_Game;
//I changed the values of the strength and HP, and I added new logic to the methods about potions

StartMenu.StartMenuText();
int option = UserChoice.PickOption(3);
Console.Clear();
BaseHero hero = UserChoice.FirstOption(option);
Console.Clear();
StartMenu.ChooseClassText();
option = UserChoice.PickOption(4);
hero = UserChoice.ChooseClass(option, hero);
Console.Clear();
StartMenu.GameplayText();
option = UserChoice.PickOption(6);
UserChoice.Gameplay(option, hero);

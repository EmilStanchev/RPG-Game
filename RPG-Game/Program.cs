// See https://aka.ms/new-console-template for more information

using RPG_Game;
using Storages;

StartMenu.StartMenuText();
int option = UserChoice.PickOption();
UserChoice.FirstOption(option);
foreach (var item in HeroStorage.Heroes)
{
    Console.WriteLine(item.Name);
}
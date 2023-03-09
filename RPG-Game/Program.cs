// See https://aka.ms/new-console-template for more information

using Heroes.Models;
using RPG_Game;

StartMenu.StartMenuText();
int option = UserChoice.PickOption();
BaseHero hero = UserChoice.FirstOption(option);
StartMenu.ChooseClassText();
option = UserChoice.PickOption();
UserChoice.ChooseClass(option, hero);
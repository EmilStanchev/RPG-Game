// See https://aka.ms/new-console-template for more information

using Heroes.Models;
using RPG_Game;
// changed the values of the hero classes 

StartMenu.StartMenuText();
int option = UserChoice.PickOption();
BaseHero hero = UserChoice.FirstOption(option);
StartMenu.ChooseClassText();
option = UserChoice.PickOption();
hero = UserChoice.ChooseClass(option, hero);
StartMenu.GameplayText();
option = UserChoice.PickOption();
UserChoice.Gameplay(option, hero);

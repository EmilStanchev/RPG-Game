using Actions;
using Shop.Models;

namespace Storages
{
    public static class ShopStorage
    {
        public static List<Sword> Swords { get; set; } = StorageAction.AllSwords();
        public static List<Potion> Potions { get; set; } = StorageAction.AllPotions();

    }
}

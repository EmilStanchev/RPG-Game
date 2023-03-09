using Actions;
using Monsters.Models;

namespace Storages
{
    public static class MonsterStorage
    {
        public static List<Monster> Monsters { get; set; } = StorageAction.CreatingMonster();

    }
}
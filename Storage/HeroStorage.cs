using Heroes.Models;

namespace Storages
{
    public static class HeroStorage
    {
        public static List<BaseHero> Heroes { get; set; } = new List<BaseHero>();
    }
}

using Interfaces.ShopInterfaces;

namespace Shop.Models
{
    public class BaseShopModel : IBaseShopModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

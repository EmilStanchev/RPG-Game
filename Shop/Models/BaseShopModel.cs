using Interfaces.ShopInterfaces;

namespace Shop.Models
{
    public class BaseShopModel : IBaseShopModel
    {
        public BaseShopModel(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

using Maqaoplus.Models.Shop;

namespace Maqaoplus.Models.Cart
{
    public class Item
    {
        public ShopProductDetailData? Product { get; set; }

        public int Quantity { get; set; }
    }
}

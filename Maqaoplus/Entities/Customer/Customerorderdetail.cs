using Maqaoplus.Models.Cart;
using Maqaoplus.Models.Shop;

namespace Maqaoplus.Entities.Customer
{
    public class Customerorderdetail
    {
        public long Customerid { get; set; }
        public List<Item>? CartItems { get; set; }
        public long Deliveryid { get; set; }
        public decimal Orderamount { get; set; }
    }
}

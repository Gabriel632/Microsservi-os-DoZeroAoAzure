using GeekShopping.MessageBus;
using GeekShopping.OrderAPI.Data.ValueObjects;

namespace GeekShopping.OrderAPI.Messages
{
    public class CheckoutHeaderVO : BaseMessage
    {
        public string UserId { get; set; }
        public string CouponCode { get; set; } = "";
        public decimal PurchaseAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateTime { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CartNumber { get; set; }
        public string CVV { get; set; }
        public string ExpiryMothYear { get; set; }
        public int CatTotalItens { get; set; }
        public IEnumerable<CartDetailVO> CartDetails { get; set; }
    }
}

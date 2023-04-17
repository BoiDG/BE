namespace BelajarNextJsBackEnd.Entities
{
    public class Cart
    {
        public string Id { set; get; } = "";

        public string UserId { set; get; } = "";

        public string RestaurantId { set; get; } = "";

        public User User { set; get; } = null!;

        public Restaurant Restaurant { set; get; } = null!;

        public List<CartDetail> CartDetails { get; set; } = new List<CartDetail>();

    }
}
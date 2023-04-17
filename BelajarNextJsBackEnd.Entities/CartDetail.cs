namespace BelajarNextJsBackEnd.Entities
{
    public class CartDetail
    {
        public string Id { set; get; } = null!;

        public string CartId { set; get; } = null!;

        public string FoodItemId { set; get; } = null!;

        public int Quantity { set; get; }

        public Cart Cart { set; get; } = null!;

        public FoodItem FoodItem { set; get; } = null!;

    }
}
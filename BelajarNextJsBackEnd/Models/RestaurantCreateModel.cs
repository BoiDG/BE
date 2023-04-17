namespace BelajarNextJsBackEnd.Models
{
    public class RestaurantCreateModel
    {
        public string Name { get; set; } = "";
        
    }

    public class AddToCartModel
    {
        public string FoodItemId { set; get; } = "";

        public int Qty { set; get; }
    }
}

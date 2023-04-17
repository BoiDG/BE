namespace BelajarNextJsBackEnd.Entities
{
    public class Restaurant
    {
        public string Id { set; get; } = "";

        public string Name { get; set; } = "";

        public List<FoodItem> FoodItems { get; set; } = new List<FoodItem>();


    }
}
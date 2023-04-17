namespace BelajarNextJsBackEnd.Entities
{
    public class PurchaseOrderDetail
    {
        public string Id { set; get; } = null!;

        public string FoodItemId { set; get; } = null!;

        public FoodItem FoodItem { set; get; } = null!;

        public int Quantity { set; get; }

        public string PurchaseOrderId { set; get; } = null!;

        public PurchaseOrder PurchaseOrder { set; get; } = null!;
    }
}

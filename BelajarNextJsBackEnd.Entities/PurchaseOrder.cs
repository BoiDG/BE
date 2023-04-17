using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BelajarNextJsBackEnd.Entities
{
    public class PurchaseOrder
    {
        public string Id { set; get; } = "";

        public string UserId { set; get; } = "";

        public User User { set; get; } = null!;

        public string PurchaseOrderStatusId { set; get; } = "";

        public PurchaseOrderStatus PurchaseOrderStatus { set; get; } = null!;

        public List<PurchaseOrderDetail> PurchaseOrderDetails { set; get; } = new List<PurchaseOrderDetail>();

    }
}

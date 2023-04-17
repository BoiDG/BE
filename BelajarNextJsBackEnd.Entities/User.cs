using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarNextJsBackEnd.Entities
{
    public class User
    {
        public string Id { set; get; } = "";

        public string Name { set; get; } = "";

        public string Email { set; get; } = "";

        public string Password { set; get; } = "";

        public List<PurchaseOrder> PurchaseOrders { set; get; } = new List<PurchaseOrder>();

    }
}

using System;
using System.Collections.Generic;

namespace Crm_WASM.Shared.Models
{
    public partial class Order
    {
        public long Id { get; set; }
        public string OrderName { get; set; }
        public string DispatchAdress { get; set; }
        public string TargetAdress { get; set; }
        public string Weight { get; set; }
        public string SendingProduct { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public long CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}

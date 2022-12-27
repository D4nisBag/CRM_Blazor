using System;
using System.Collections.Generic;
using System.Text;

namespace Crm_WASM.Shared
{
    public class Order
    {
        public long OrderId { get; set; }
        public long CustomerId { get; set; }
        public string OrderName { get; set; }
        public string DispatchAdress { get; set; }
        public string TargetAdress { get; set; }
        public string Weight { get; set; }
        public string SendingProduct { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }

        public Order()
        {

        }

        public Order(long OrderId, long CustomerId, string OrderName, string DispatchAdress,
            string TargetAdress, string Weight,string SendingProduct, string Status, string Message)
        {
            this.OrderId= OrderId;
            this.CustomerId= CustomerId;
            this.OrderName= OrderName;
            this.DispatchAdress= DispatchAdress;
            this.TargetAdress= TargetAdress;
            this.Weight= Weight;
            this.SendingProduct= SendingProduct;
            this.Status= Status;
            this.Message= Message;
        }

    }
}

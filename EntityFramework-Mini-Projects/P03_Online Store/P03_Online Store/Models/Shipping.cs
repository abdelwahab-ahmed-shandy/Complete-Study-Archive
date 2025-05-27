using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_Online_Store.Models
{
    public enum ShippingStatus
    {
        Pending ,
        Shipped ,
        Delivered ,
        Cancelled 
    }
    internal class Shipping
    {
        public int ShippingId { get; set; }
        public string CarrierName { get; set; }
        public string TrackingNumber { get; set; }
        public ShippingStatus ShippingStatus { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
        public DateTime ActualDeliveryDate { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

    }
}

using System;

namespace InterfaceTestability
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            // if shipment property is not null, this method returns true
            get { return Shipment != null; }
        }
 
    }
}
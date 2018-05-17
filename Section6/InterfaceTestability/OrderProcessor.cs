using System;

// we don't want any reference to the shipping calculator concrete class, we just are referencing an interface
// we can isolate this now during unit testing
namespace InterfaceTestability
{
    public class OrderProcessor
    {
 
        // private readonly ShippingCalculator _shippingCalculator;
        private readonly IShippingCalculator _shippingCalculator;

        // loose coupling
        // if we change shipping calculator class, it doesnt matter here
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            // _shippingCalculator = new ShippingCalculator();
            _shippingCalculator = shippingCalculator;
            
        }

        public void Process(Order order)
        {
            // defensive programming
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already processed");
            }

            // create object of type Shipment and assign to Shipment property
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
 
    }
}
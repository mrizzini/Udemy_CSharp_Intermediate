using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// an interface defines the public interface or the public functionality
// or the public service that a class provides

namespace InterfaceTestability.UnitTests
{
    [TestClass]
    [ExpectedException(typeof(InvalidOperationException))]
    public class OrderProcessorTests
    {
        // METHODNAME_CONDITION_EXPECTION ---- NAMING CONVENTION
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            // need to pass a fake object that is always working to isolate the order processor
            var orderProcessor = new orderProcessor(new FakeShippingCalculator());
            // isShipped will be true
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new orderProcessor(new FakeShippingCalculator());
            // isShipped will be false in this new order
            var order = new Order();

            orderProcessor.Process(order);

            // isShipped should be true
            Assert.IsTrue(order.IsShipped);
            // cost should be one
            Assert.AreEqual(1, order.Shipment.Cost);
            // date should be this
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
            
        }
 
 
 
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
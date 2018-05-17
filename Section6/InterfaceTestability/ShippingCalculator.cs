using System;

namespace InterfaceTestability
{
    // need to create an interface here
    // this will define the capability that a class should provide
    public interface IShippingCalculator
    {

        // method with NO body and no access modifier
        float CalculateShipping(Order order);
    }
    
    // need to have the shipping calculator class implenet the shipping calculator interface
    // ShippingCalculator implements IShippingCalculator
    public class ShippingCalculator : IShippingCalculator
    {

        public float CalculateShipping(Order order)
        {
            // if total price is more than 30, then we return 10% of that total price for the shipping amount
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }

            // else, free shipping!
            return 0;
        }
    }
}
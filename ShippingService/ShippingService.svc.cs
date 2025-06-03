using System;

namespace ShippingService
{
    public class Service1 : IService1
    {
        public double CalculateShipping(double weightKg, string region)
        {
            double baseRate = region == "Europe" ? 5 : 10;
            return baseRate + weightKg * 2;
        }
    }
}

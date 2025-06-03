using System.ServiceModel;

namespace ShippingService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        double CalculateShipping(double weightKg, string region);
    }
}

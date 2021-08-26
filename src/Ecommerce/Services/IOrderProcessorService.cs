using Ecommerce.Model;

namespace Ecommerce.Services
{
    internal interface IOrderProcessorService
    {
        decimal Process(Order order);
    }
}
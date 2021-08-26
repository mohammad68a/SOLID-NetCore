using Ecommerce.Model;
using Ecommerce.Repositories;

namespace Ecommerce.Services
{
    class OrderProcessorService : IOrderProcessorService
    {
        private readonly IDiscountService discountService;
        private readonly ITaxRepository taxRepository;
        private readonly IOrderRepository orderRepository;

        public OrderProcessorService(IDiscountService discountService, ITaxRepository taxRepository, IOrderRepository orderRepository)
        {
            this.discountService = discountService;
            this.taxRepository = taxRepository;
            this.orderRepository = orderRepository;
        }

        public decimal Process(Order order)
        {
            order.Discount = discountService.GetDiscount(order.Discount.Number);
            order.Tax = taxRepository.GetByLocation(order.Country, order.State);
            
            order.Discount.Apply();
            decimal total = order.GetTotal();

            orderRepository.Save(order);
            discountService.ApplyDiscount(order.Discount.Number);

            return total;
        }
    }
}

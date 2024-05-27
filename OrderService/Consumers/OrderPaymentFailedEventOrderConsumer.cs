using MassTransit;
using Shared.Events;

namespace OrderService.Consumers
{
    public class OrderPaymentFailedEventOrderConsumer : IConsumer<OrderPaymentFailed>
    {
        public async Task Consume(ConsumeContext<OrderPaymentFailed> context)
        {
            Console.WriteLine($"Order payment failed: {context.Message.OrderId}\n");

        }
    }
}

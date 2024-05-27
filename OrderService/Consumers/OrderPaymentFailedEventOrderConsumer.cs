using MassTransit;
using Shared.Events;

namespace OrderService.Consumers
{
    public class OrderPaymentFailedEventOrderConsumer : IConsumer<IOrderPaymentFailed>
    {
        public async Task Consume(ConsumeContext<IOrderPaymentFailed> context)
        {
            Console.WriteLine($"Order payment failed: {context.Message.OrderId}\n");

        }
    }
}

using MassTransit;
using Shared.Events;

namespace Shared.Consumers.OrderService
{
    public class OrderPaymentSucceededEventOrderConsumer : IConsumer<IOrderPaymentSucceeded>
    {
        public async Task Consume(ConsumeContext<IOrderPaymentSucceeded> context)
        {
            Console.WriteLine($"Order payment succeeded: {context.Message.OrderId}\n");

        }
    }
}

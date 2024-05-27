using MassTransit;
using Shared.Events;

namespace BasketService.Consumers
{
    public class OrderPaymentFailedEventBasketConsumer : IConsumer<OrderPaymentFailed>
    {
        public Task Consume(ConsumeContext<OrderPaymentFailed> context)
        {
            Console.WriteLine(context.Message.OrderId + " siparişinin ödemesi alınamadı. => sepet hala dolu!");
            return Task.CompletedTask;
        }
    }
}

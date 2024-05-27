using MassTransit;
using Shared.Events;

namespace BasketService.Consumers
{
    public class OrderPaymentFailedEventBasketConsumer : IConsumer<IOrderPaymentFailed>
    {
        public Task Consume(ConsumeContext<IOrderPaymentFailed> context)
        {
            Console.WriteLine(context.Message.OrderId + " siparişinin ödemesi alınamadı. => sepet hala dolu!");
            return Task.CompletedTask;
        }
    }
}

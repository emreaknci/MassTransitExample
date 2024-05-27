using MassTransit;
using Shared.Events;

namespace BasketService.Consumers
{
    public class OrderPaymentSucceededEventBasketConsumer : IConsumer<OrderPaymentSucceeded>
    {
        public Task Consume(ConsumeContext<OrderPaymentSucceeded> context)
        {
            Console.WriteLine(context.Message.OrderId + "siparişinin ödemesi alındı => sepet temizlendi");
            return Task.CompletedTask;
        }
    }
}

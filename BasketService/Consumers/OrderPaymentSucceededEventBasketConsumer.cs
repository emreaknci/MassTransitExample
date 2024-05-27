using MassTransit;
using Shared.Events;

namespace BasketService.Consumers
{
    public class OrderPaymentSucceededEventBasketConsumer : IConsumer<IOrderPaymentSucceeded>
    {
        public Task Consume(ConsumeContext<IOrderPaymentSucceeded> context)
        {
            Console.WriteLine(context.Message.OrderId + "siparişinin ödemesi alındı => sepet temizlendi");
            return Task.CompletedTask;
        }
    }
}

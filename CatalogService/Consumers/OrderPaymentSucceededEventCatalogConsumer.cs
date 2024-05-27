using MassTransit;
using Shared.Events;

namespace CatalogService.Consumers
{
    public class OrderPaymentSucceededEventCatalogConsumer : IConsumer<OrderPaymentSucceeded>
    {
        public Task Consume(ConsumeContext<OrderPaymentSucceeded> context)
        {
            Console.WriteLine("\n" + context.Message.OrderId + "siparişinin ödemesi alındı");


            return Task.CompletedTask;
        }
    }
}

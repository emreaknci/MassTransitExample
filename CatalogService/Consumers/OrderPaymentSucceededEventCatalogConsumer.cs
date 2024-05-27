using MassTransit;
using Shared.Events;

namespace CatalogService.Consumers
{
    public class OrderPaymentSucceededEventCatalogConsumer : IConsumer<IOrderPaymentSucceeded>
    {
        public Task Consume(ConsumeContext<IOrderPaymentSucceeded> context)
        {
            Console.WriteLine("\n" + context.Message.OrderId + "siparişinin ödemesi alındı");


            return Task.CompletedTask;
        }
    }
}

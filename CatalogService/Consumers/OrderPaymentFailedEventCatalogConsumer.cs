using MassTransit;
using Shared.Events;

namespace CatalogService.Consumers
{
    public class OrderPaymentFailedEventCatalogConsumer : IConsumer<OrderPaymentFailed>
    {
        public Task Consume(ConsumeContext<OrderPaymentFailed> context)
        {
            Console.WriteLine("\n" + context.Message.OrderId + " siparişinin ödemesi başarısız oldu. Stok tekrar güncelleniyor");
            foreach (var item in context.Message.Items)
            {
                Console.WriteLine($"{item.Key} ürününden {item.Value} adet stoklara eklendi");
            }

            return Task.CompletedTask;
        }
    }
}

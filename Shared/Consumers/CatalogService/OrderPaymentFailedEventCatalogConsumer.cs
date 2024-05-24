using MassTransit;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Consumers.CatalogService
{
    public class OrderPaymentFailedEventCatalogConsumer : IConsumer<IOrderPaymentFailed>
    {
        public Task Consume(ConsumeContext<IOrderPaymentFailed> context)
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

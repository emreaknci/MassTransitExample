using MassTransit;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Consumers.CatalogService
{
    public class OrderStartedEventCatalogConsumer : IConsumer<IOrderStartedEvent>
    {
        public Task Consume(ConsumeContext<IOrderStartedEvent> context)
        {
            var message = context.Message;

            Console.Out.WriteLineAsync($"\n#{message.OrderId} siparişi oluşturuldu.");
            foreach (var item in message.Items)
            {
                Console.WriteLine($"{item.Key} ürününden {item.Value} adet stoklardan düştü");
            }

            return Task.CompletedTask;
        }
    }
}

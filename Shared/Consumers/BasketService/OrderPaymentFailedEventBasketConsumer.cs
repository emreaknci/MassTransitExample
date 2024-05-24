using MassTransit;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Consumers.BasketService
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

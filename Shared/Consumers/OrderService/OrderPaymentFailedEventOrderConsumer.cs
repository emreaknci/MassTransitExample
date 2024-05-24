using MassTransit;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Consumers.OrderService
{
    public class OrderPaymentFailedEventOrderConsumer : IConsumer<IOrderPaymentFailed>
    {
        public async Task Consume(ConsumeContext<IOrderPaymentFailed> context)
        {
            Console.WriteLine($"Order payment failed: {context.Message.OrderId}\n");

        }
    }
}

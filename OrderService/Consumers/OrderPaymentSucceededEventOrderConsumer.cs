﻿using MassTransit;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Consumers
{
    public class OrderPaymentSucceededEventOrderConsumer : IConsumer<OrderPaymentSucceeded>
    {
        public async Task Consume(ConsumeContext<OrderPaymentSucceeded> context)
        {
            Console.WriteLine($"Order payment succeeded: {context.Message.OrderId}\n");

        }
    }
}

using MassTransit;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Consumers
{
    public class OrderStartedEventPaymentConsumer : IConsumer<IOrderStartedEvent>
    {


        public async Task Consume(ConsumeContext<IOrderStartedEvent> context)
        {
            var message = context.Message;
            var success = new Random().Next(0, 2) == 1;

            await Console.Out.WriteLineAsync($"\n#{message.OrderId} payment being received... => {(success ? "successful" : "unsuccessful")}");
            await SendPaymentStatus(context, success);
        }

        public async Task SendPaymentStatus(ConsumeContext<IOrderStartedEvent> context, bool success)
        {
            Console.WriteLine($"Payment for order with id {context.Message.OrderId} was {(success ? "successful" : "unsuccessful")}\n");

            if (success)
            {
                IOrderPaymentSucceeded succeeded = new OrderPaymentSucceeded()
                {
                    OrderId = context.Message.OrderId
                };
                await context.Publish(succeeded);
            }

            else
            {
                Dictionary<string, int> items = new Dictionary<string, int>();
                foreach (var item in context.Message.Items)
                {
                    items.Add(item.Key, item.Value);
                }
                IOrderPaymentFailed failed = new OrderPaymentFailed()
                {
                    OrderId = context.Message.OrderId,
                    Items = items
                };
                await context.Publish(failed);
            }

        }
    }
}

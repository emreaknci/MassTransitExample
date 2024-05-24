using MassTransit;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Consumers.NotificationService
{
    public class OrderPaymentSucceededEventNotificationConsumer : IConsumer<IOrderPaymentSucceeded>
    {
        public Task Consume(ConsumeContext<IOrderPaymentSucceeded> context)
        {
            var message=context.Message;
            Console.WriteLine($"${message.OrderId} li siparişin ödemesi başarıyla alınmıştır. Siparişiniz en kısa sürede kargoya verilecektir.");
            return Task.CompletedTask;
        }
    }
    public class OrderPaymentFailedEventNotificationConsumer : IConsumer<IOrderPaymentFailed>
    {
        public Task Consume(ConsumeContext<IOrderPaymentFailed> context)
        {
            var message = context.Message;
            Console.WriteLine($"${message.OrderId} li siparişin ödemesi sırasında bir hata oluştu.");
            return Task.CompletedTask;
        }
    }
}

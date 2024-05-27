using MassTransit;
using Shared.Events;

namespace NotificationService.Consumers
{
    public class OrderPaymentFailedEventNotificationConsumer : IConsumer<OrderPaymentFailed>
    {
        public Task Consume(ConsumeContext<OrderPaymentFailed> context)
        {
            var message = context.Message;
            Console.WriteLine($"${message.OrderId} li siparişin ödemesi sırasında bir hata oluştu.");
            return Task.CompletedTask;
        }
    }
}

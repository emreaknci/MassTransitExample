using MassTransit;
using NotificationService.Consumers;
using Shared;

var bus = BusConfigurator.ConfigureBus(configuration =>
{
    configuration.ReceiveEndpoint(RabbitMQConstants.NotificationServiceQueueName, e =>
    {
        e.Consumer<OrderPaymentSucceededEventNotificationConsumer>();
        e.Consumer<OrderPaymentFailedEventNotificationConsumer>();
    });
});


await bus.StartAsync();

Console.WriteLine("Listening notification commands... Press any key to exit.");
Console.ReadKey();

await bus.StopAsync();

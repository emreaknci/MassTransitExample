using MassTransit;
using Shared;
using OrderService.Consumers;

var bus = BusConfigurator.ConfigureBus(configuration =>
{
    configuration.ReceiveEndpoint(RabbitMQConstants.OrderServiceQueueName, e =>
    {
        e.Consumer<OrderCreatedCommandConsumer>();
        e.Consumer<OrderPaymentFailedEventOrderConsumer>();
        e.Consumer<OrderPaymentSucceededEventOrderConsumer>();
    });
});

await bus.StartAsync();

Console.WriteLine("Listening order commands... Press any key to exit.");
Console.ReadKey();

await bus.StopAsync();
using MassTransit;
using Shared;
using Shared.Consumers.CatalogService;

var bus = BusConfigurator.ConfigureBus(configuration =>
{
    configuration.ReceiveEndpoint(RabbitMQConstants.CatalogServiceQueueName, e =>
    {
        e.Consumer<OrderStartedEventCatalogConsumer>();
        e.Consumer<OrderPaymentSucceededEventCatalogConsumer>();
        e.Consumer<OrderPaymentFailedEventCatalogConsumer>();
    });
});

await bus.StartAsync();

Console.WriteLine("Listening catalog events... Press any key to exit.");
Console.ReadKey();

await bus.StopAsync();
using MassTransit;
using Shared;
using PaymentService.Consumers;

var bus = BusConfigurator.ConfigureBus(configuration =>
{
    configuration.ReceiveEndpoint(RabbitMQConstants.PaymentServiceQueueName, e =>
    {
        e.Consumer<OrderStartedEventPaymentConsumer>();
    });
});

await bus.StartAsync();

Console.WriteLine("Listening payment commands... Press any key to exit.");
Console.ReadKey();

await bus.StopAsync();
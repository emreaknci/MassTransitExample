using MassTransit;
using Shared;
using BasketService.Consumers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<OrderPaymentSucceededEventBasketConsumer>();
    x.AddConsumer<OrderPaymentFailedEventBasketConsumer>();

    x.UsingRabbitMq((context, config) =>
    {
        config.ReceiveEndpoint(RabbitMQConstants.BasketServiceQueueName, e =>
        {
            e.Consumer<OrderPaymentSucceededEventBasketConsumer>();
            e.Consumer<OrderPaymentFailedEventBasketConsumer>();
        });
    });

});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

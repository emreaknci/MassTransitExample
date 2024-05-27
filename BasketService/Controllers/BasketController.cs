using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Commands;
using Shared.Events;

namespace BasketService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly ISendEndpoint _bus;

        public BasketController()
        {
            var bus = BusConfigurator.ConfigureBus();
            var sendToUri = new Uri($"{RabbitMQConstants.Uri}/{RabbitMQConstants.OrderServiceQueueName}");
            _bus = bus.GetSendEndpoint(sendToUri).Result;
        }

        [HttpPost("checkout")]
        public async Task<IActionResult> Post()
        {
            var randomId = new Random().Next(1, 100);

            var orderCreated = new OrderCreatedCommand()
            {
                OrderId = randomId,
                Items = new List<BasketItem>
                {
                    new BasketItem
                    {
                        Id= new Random().Next(1, 20),
                        Name="Product 1",
                        Units= new Random().Next(1, 5)
                    },
                    new BasketItem
                    {
                      Id= new Random().Next(1, 20),
                        Name="Product 2",
                        Units= new Random().Next(1, 5)
                    }
                }
            };

            await _bus.Send<OrderCreatedCommand>(orderCreated);

            return Ok("Order created successfully.");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PizzaDelivery.Server.Data;
using PizzaDelivery.Server.Model;
using Stripe;
using Stripe.Checkout;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly string _stripeSecretKey;
        private readonly string _stripePublishableKey;

        public PaymentController(ApplicationDbContext context, IOptions<StripeSettings> stripeSettings)
        {
            _context = context;
            _stripeSecretKey = stripeSettings.Value.SecretKey;
            _stripePublishableKey = stripeSettings.Value.PublishableKey;
            StripeConfiguration.ApiKey = _stripeSecretKey;
        }

        [HttpPost("CreateCheckoutSession")]
        public async Task<IActionResult> CreateCheckoutSession(int orderId)
        {
            var order = await _context.Orders
                .Include(o => o.items)
                .FirstOrDefaultAsync(o => o.id == orderId);

            if (order == null)
            {
                return NotFound();
            }

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>(),
                Mode = "payment",
                SuccessUrl = Url.Action("Success", "Payment", null, Request.Scheme),
                CancelUrl = Url.Action("Cancel", "Payment", null, Request.Scheme)
            };

            foreach (var item in order.items)
            {
                var pizza = await _context.Pizzas.FindAsync(item.pizza_id);
                if (pizza == null)
                {
                    continue;
                }

                options.LineItems.Add(new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)(item.price * 100), 
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = pizza.name,
                            Description = pizza.description
                        }
                    },
                    Quantity = item.quantity
                });
            }

            var service = new SessionService();
            Session session = service.Create(options);

            return Ok(new { id = session.Id });
        }

        [HttpGet("Success")]
        public IActionResult Success()
        {
            return Ok("Payment was successful.");
        }

        [HttpGet("Cancel")]
        public IActionResult Cancel()
        {
            return Ok("Payment was canceled.");
        }
    }
}

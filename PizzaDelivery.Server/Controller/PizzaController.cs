using Microsoft.AspNetCore.Mvc;
using PizzaDelivery.Server.Data;
using PizzaDelivery.Server.DTO;
using Microsoft.EntityFrameworkCore;

namespace PizzaDelivery.Server.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PizzaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PizzaDTO>>> GetPizzas()
        {
            var pizzas = await _context.Pizzas
                .Select(p => new PizzaDTO
                {
                    name = p.name,
                    price = p.price,
                    category = p.category,
                    description = p.description,
                    image_url = p.image_url,
                    size = p.size
                })
                .ToListAsync();

            return Ok(pizzas);
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeneratingRandomNumberController : ControllerBase
    {
        private readonly Random _random = new Random();

        // GET: api/GeneratingRandomNumber

        [HttpGet]
        public IActionResult Get()
        {
            // Generate a random number between 1 and 100 (inclusive)
            int randomNumber = _random.Next(1, 101);

            // Return the number as JSON
            return Ok(new { Number = randomNumber });
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Rest_calculadora_APSNET_6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firtsNum}/{secondNum}")]
        public IActionResult Sum(string firtsNum, string secondNum)
        {
            int num1;
            int num2;
            bool success = int.TryParse(firtsNum, out num1);
            bool success1 = int.TryParse(secondNum, out num2);
            if (success && success1)
            {
                int sum = num1 + num2;
                return Ok(sum.ToString());
            }

            return BadRequest("input invalido");

        }
        [HttpGet("sub/{firtsNum}/{secondNum}")]
        public IActionResult Subtration(string firtsNum, string secondNum)
        {
            int num1;
            int num2;
            bool success = int.TryParse(firtsNum, out num1);
            bool success1 = int.TryParse(secondNum, out num2);
            if (success && success1)
            {
                int sub = num1 - num2;
                return Ok(sub.ToString());
            }

            return BadRequest("input invalido");

        }

        [HttpGet("multiple/{firtsNum}/{secondNum}")]
        public IActionResult Multiplie(string firtsNum, string secondNum)
        {
            int num1;
            int num2;
            bool success = int.TryParse(firtsNum, out num1);
            bool success1 = int.TryParse(secondNum, out num2);
            if (success && success1)
            {
                int mult = num1 * num2;
                return Ok(mult.ToString());
            }

            return BadRequest("input invalido");

        }
        [HttpGet("division/{firtsNum}/{secondNum}")]
        public IActionResult Division(string firtsNum, string secondNum)
        {
            int num1;
            int num2;
            bool success = int.TryParse(firtsNum, out num1);
            bool success1 = int.TryParse(secondNum, out num2);
            if (success && success1)
            {
                int div = num1 / num2;
                return Ok(div.ToString());
            }

            return BadRequest("input invalido");

        }

        [HttpGet("media/{firtsNum}/{secondNum}")]
        public IActionResult Media(string firtsNum, string secondNum)
        {
            int num1;
            int num2;
            bool success = int.TryParse(firtsNum, out num1);
            bool success1 = int.TryParse(secondNum, out num2);
            if (success && success1)
            {
                int media = (num1 + num2)/2;
                return Ok(media.ToString());
            }

            return BadRequest("input invalido");

        }

        [HttpGet("square-root/{num}")]
        public IActionResult SquareRoot(string num)
        {
            double num1;
            bool success = double.TryParse(num, out num1);
            if (success)
            {
                double squareRoot = Math.Sqrt(num1);
                return Ok(squareRoot.ToString());
            }

            return BadRequest("input invalido");

        }

    }
}

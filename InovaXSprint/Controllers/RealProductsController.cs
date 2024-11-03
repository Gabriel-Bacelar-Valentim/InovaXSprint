using InovaX.API.Extensions;
using InovaX.Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace InovaX.API.Controllers
{
    [Route("api/[controller]")]
    public class RealProductsController : ControllerBase
    {
        private readonly RealProductsService _productService;

        public RealProductsController(RealProductsService productService)
        {
            _productService = productService;
        }

        [HttpGet("{name}")]
        public ActionResult<List<RealProducts>> GetProductsByName(string name)
        {
            var products = _productService.GetProductsByName(name);
            if (products == null || !products.Any())
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpGet("predict-price")]
        public ActionResult<float> PredictPrice([FromQuery] string name, [FromQuery] string category)
        {
            var predictedPrice = _productService.PredictPrice(name, category);
            return Ok(predictedPrice);
        }
    }
}


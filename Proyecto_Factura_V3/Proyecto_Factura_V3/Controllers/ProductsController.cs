using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto_Factura_V3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        private readonly IProductService _productService;

        public ProductsController(IProductService productService, ILogger<ProductsController> logger)
        {
            _productService = productService;
            

            _logger = logger;
        }

        [HttpGet("{id}")]
        public ProductViewModel Get(int id) //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            var product = _productService.GetProduct(id);
            var viewProduct = new ProductViewModel
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ProductId = product.ProductId
            };
            return viewProduct;
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Potection against bots
        public IActionResult Post([FromBody] ProductRequestPost request)
        {
            _productService.AddProduct(new Product
            {
                Name = request.Name,
                Description = request.Description,
                Manufacturer = request.Manufacturer,
                Price = request.Price,
                DateOfEntry = DateTime.Now,
                BranchId = request.BranchId
            });
            return Ok();
        }

        [HttpPut]
        [ValidateAntiForgeryToken] //Potection against bots
        public IActionResult Put([FromBody] ProductRequestPut request)
        {
            var product = _productService.GetProduct(request.ProductId);
            product.Name = request.Name;
            product.Description = request.Description;
            product.Manufacturer = request.Manufacturer;
            product.Price = request.Price;
            product.BranchId = request.BranchId;
            _productService.UpdateProduct(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            _productService.DeleteProduct(id);
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
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

        private readonly IProductService _service;

        public ProductsController(IProductService service, ILogger<ProductsController> logger)
        {
            _service = service;

            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<Product> Get(int id) //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            return await _service.GetId(id);
        }
        
        [HttpGet]
        public List<Product> Get() //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            return _service.GetAll();
        }


        [HttpPost]
        public async Task<Product> Post([FromBody] ProductRequest request)
        {
            return await _service.AddEntity(request);
        }


        [HttpPut("{id}")]
        public async Task<Product> Put(int id, [FromBody] ProductRequest request)
        {
            return await _service.UpdateEntity(id, request);
        }


        [HttpDelete("{id}")]
        public async Task Delete(int id) 
        {
            await _service.DeleteId(id);
        }
    }
}

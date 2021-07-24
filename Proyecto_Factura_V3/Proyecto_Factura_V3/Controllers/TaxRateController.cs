using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxRateController : ControllerBase
    {
        private readonly ILogger<TaxRateController> _logger;

        private readonly ITaxRateService _service;

        public TaxRateController(ITaxRateService service, ILogger<TaxRateController> logger)
        {
            _service = service;

            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<TaxRate> Get(int id) //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            return await _service.GetId(id);
        }
        
        [HttpGet]
        public List<TaxRate> Get() //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            return _service.GetAll();
        }


        [HttpPost]
        [ValidateAntiForgeryToken] //Potection against bots
        public async Task<TaxRate> Post([FromBody] TaxRate request)
        {
            await _service.AddEntity(request);
            return request;
        }


        [HttpPut("{id}")]
        [ValidateAntiForgeryToken] //Potection against bots
        public async  Task<TaxRate> Put(int id, [FromBody] TaxRate request)
        {
            var model = await _service.GetId(id);
            await _service.UpdateEntity(model);
            return model;
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) 
        {
            await _service.DeleteId(id);
            return Ok();
        }
    }
}

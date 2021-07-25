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
    public class TaxRatesController : ControllerBase
    {
        private readonly ILogger<TaxRatesController> _logger;

        private readonly ITaxRateService _service;

        public TaxRatesController(ITaxRateService service, ILogger<TaxRatesController> logger)
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
        public async Task<TaxRate> Post([FromBody] TaxRateRequest request)
        {
            return await _service.AddEntity(request);
        }


        [HttpPut]
        public async Task<TaxRate> Put([FromBody] TaxRate request)
        {
            await _service.UpdateEntity(request);
            return request;
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) 
        {
            await _service.DeleteId(id);
            return Ok();
        }
    }
}

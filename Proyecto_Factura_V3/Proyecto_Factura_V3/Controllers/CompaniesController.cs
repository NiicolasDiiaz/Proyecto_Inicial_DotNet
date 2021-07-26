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
    public class CompaniesController : ControllerBase
    {
        private readonly ILogger<CompaniesController> _logger;

        private readonly ICompanyService _service;

        public CompaniesController(ICompanyService service, ILogger<CompaniesController> logger)
        {
            _service = service;

            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<Company> Get(int id) //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            return await _service.GetId(id);
        }
        
        [HttpGet]
        public List<Company> Get() //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            return _service.GetAll();
        }


        [HttpPost]
        public async Task<Company> Post([FromBody] CompanyRequest request)
        {
            return await _service.AddEntity(request);
        }


        [HttpPut("{id}")]
        public async Task<Company> Put(int id, [FromBody] CompanyRequest request)
        {
            return await _service.UpdateEntity(id, request);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) 
        {
            await _service.DeleteId(id);
            return Ok();
        }
    }
}

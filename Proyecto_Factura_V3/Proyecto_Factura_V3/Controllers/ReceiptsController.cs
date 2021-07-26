using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using Proyecto_Factura_V3.Services;
using Proyecto_Factura_V3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReceiptsController : ControllerBase
    {
        private readonly ILogger<ReceiptsController> _logger;

        private readonly IReceiptHeadService _service;

        public ReceiptsController(IReceiptHeadService service, ILogger<ReceiptsController> logger)
        {
            _service = service;

            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<ReceiptHeadView> Get(int id) //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            return await _service.GetId(id);
        }
        
        [HttpGet]
        public async Task<List<ReceiptHeadView>> Get() //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            return await _service.GetAll();
        }


        [HttpPost]
        public async Task<ReceiptHeadView> Post([FromBody] ReceiptHeadRequest request)
        {
            return await _service.AddEntity(request);
        }


        [HttpPut]
        public async Task<ReceiptHeadView> Put([FromBody] ReceiptHead request)
        {
            return await _service.UpdateEntity(request);
        }


        [HttpDelete("{id}")]
        public async Task Delete(int id) 
        {
            await _service.DeleteId(id);
        }
    }
}

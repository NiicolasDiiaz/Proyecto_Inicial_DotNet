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
    public class ReceiptDetailsController : ControllerBase
    {
        private readonly ILogger<ReceiptDetailsController> _logger;

        private readonly IReceiptDetailService _service;

        public ReceiptDetailsController(IReceiptDetailService service, ILogger<ReceiptDetailsController> logger)
        {
            _service = service;

            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<ReceiptDetail> Get(int id) //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            return await _service.GetId(id);
        }
        
        [HttpGet]
        public List<ReceiptDetail> Get() //Deberia ser (int? id) ? Acepto null y lidio con eso
        {
            return _service.GetAll();
        }


        [HttpPost]
        public async Task<ReceiptDetail> Post([FromBody] ReceiptDetailRequest request)
        {
            return await _service.AddEntity(request);
        }


        [HttpPut]
        public async Task<ReceiptDetail> Put([FromBody] ReceiptDetail request)
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

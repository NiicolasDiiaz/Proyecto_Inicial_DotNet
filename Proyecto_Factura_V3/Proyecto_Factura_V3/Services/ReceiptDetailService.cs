using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Repositories;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public class ReceiptDetailService : IReceiptDetailService
    {
        private readonly IReceiptDetailRepository _repository;

        public ReceiptDetailService(IReceiptDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task<ReceiptDetail> GetId(int id)
        {
            return await _repository.GetId(id);
        }

        public List<ReceiptDetail> GetAll()
        {
            return _repository.GetAll();
        }


        public async Task<ReceiptDetail> AddEntity(ReceiptDetailRequest entity)
        {
            return await _repository.AddEntity(new ReceiptDetail
            {
                Quantity = entity.Quantity,
                ProductId = entity.ProductId,
                ReceiptHeadId = entity.ReceiptHeadId
            });
        }

        public async Task<ReceiptDetail> UpdateEntity(ReceiptDetail entity)
        {
            return await _repository.UpdateEntity(entity);
        }


        public async Task DeleteEntity(ReceiptDetail entity)
        {
            await _repository.DeleteEntity(entity);
        }

        public async Task DeleteId(int id)
        {
            await _repository.DeleteId(id);
        }
    }
}

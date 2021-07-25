using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Repositories;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public class ReceiptHeadService : IReceiptHeadService
    {
        private readonly IReceiptHeadRepository _repository;

        public ReceiptHeadService(IReceiptHeadRepository repository)
        {
            _repository = repository;
        }

        public async Task<ReceiptHead> GetId(int id)
        {
            return await _repository.GetId(id);
        }

        public List<ReceiptHead> GetAll()
        {
            return _repository.GetAll();
        }


        public async Task<ReceiptHead> AddEntity(ReceiptHeadRequest entity)
        {
            return await _repository.AddEntity(new ReceiptHead
            {
                BranchId = entity.BranchId,
                CustomerId = entity.CustomerId
            });
        }

        public async Task<ReceiptHead> UpdateEntity(ReceiptHead entity)
        {
            return await _repository.UpdateEntity(entity);
        }


        public async Task DeleteEntity(ReceiptHead entity)
        {
            await _repository.DeleteEntity(entity);
        }

        public async Task DeleteId(int id)
        {
            await _repository.DeleteId(id);
        }
    }
}

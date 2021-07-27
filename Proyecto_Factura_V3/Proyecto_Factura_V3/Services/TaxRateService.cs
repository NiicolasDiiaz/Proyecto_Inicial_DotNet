using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Repositories;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public class TaxRateService : ITaxRateService
    {
        private readonly ITaxRateRepository _repository;

        public TaxRateService(ITaxRateRepository repository)
        {
            _repository = repository;
        }

        public async Task<TaxRate> GetId(int id)
        {
            return await _repository.GetId(id);
        }

        public async Task<List<TaxRate>> GetAll()
        {
            return await _repository.GetAll();
        }


        public async Task<TaxRate> AddEntity(TaxRateRequest entity)
        {
            return await _repository.AddEntity(new TaxRate
            {
                Category = entity.Category,
                Rate = entity.Rate
            });
        }

        public async Task<TaxRate> UpdateEntity(int id, TaxRateRequest entity)
        {
            return await _repository.UpdateEntity(new TaxRate
            {
                TaxRateId = id,
                Category = entity.Category,
                Rate = entity.Rate
            });
        }


        public async Task DeleteEntity(TaxRate entity)
        {
            await _repository.DeleteEntity(entity);
        }

        public async Task DeleteId(int id)
        {
            await _repository.DeleteId(id);
        }
    }
}

using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Repositories;
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

        public List<TaxRate> GetAll()
        {
            return _repository.GetAll();
        }


        public async Task<TaxRate> AddEntity(TaxRate entity)
        {
            return await _repository.AddEntity(entity);
        }

        public async Task<TaxRate> UpdateEntity(TaxRate entity)
        {
            return await _repository.UpdateEntity(entity);
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

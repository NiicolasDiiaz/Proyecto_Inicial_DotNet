using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Repositories;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _repository;

        public CompanyService(ICompanyRepository repository)
        {
            _repository = repository;
        }

        public async Task<Company> GetId(int id)
        {
            return await _repository.GetId(id);
        }

        public List<Company> GetAll()
        {
            return _repository.GetAll();
        }


        public async Task<Company> AddEntity(CompanyRequest entity)
        {
            return await _repository.AddEntity(new Company
            {
                Name = entity.Name,
                Description = entity.Description,
                Nit = entity.Nit
            });
        }

        public async Task<Company> UpdateEntity(Company entity)
        {
            return await _repository.UpdateEntity(entity);
        }


        public async Task DeleteEntity(Company entity)
        {
            await _repository.DeleteEntity(entity);
        }

        public async Task DeleteId(int id)
        {
            await _repository.DeleteId(id);
        }
    }
}

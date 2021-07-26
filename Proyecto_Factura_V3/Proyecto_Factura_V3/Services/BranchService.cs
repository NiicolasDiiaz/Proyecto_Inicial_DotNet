using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Repositories;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _repository;


        public BranchService(IBranchRepository repository)
        {
            _repository = repository;
        }

        public async Task<Branch> GetId(int id)
        {
            return await _repository.GetId(id);
        }

        public List<Branch> GetAll()
        {
            return _repository.GetAll();
        }


        public async Task<Branch> AddEntity(BranchRequest entity)
        {
            return await _repository.AddEntity(new Branch
            {
                Name = entity.Name,
                Description = entity.Description,
                City = entity.City,
                Address = entity.Address,
                EmailAddress = entity.EmailAddress,
                Phone = entity.Phone,
                CompanyId = entity.CompanyId,         
                Country = entity.Country
            });
        }

        public async Task<Branch> UpdateEntity(int id, BranchRequest entity)
        {
            return await _repository.UpdateEntity(new Branch
            {
                BranchId = id,
                Name = entity.Name,
                Description = entity.Description,
                City = entity.City,
                Address = entity.Address,
                EmailAddress = entity.EmailAddress,
                Phone = entity.Phone,
                CompanyId = entity.CompanyId,
                Country = entity.Country
            });
        }


        public async Task DeleteEntity(Branch entity)
        {
            await _repository.DeleteEntity(entity);
        }

        public async Task DeleteId(int id)
        {
            await _repository.DeleteId(id);
        }
    }
}

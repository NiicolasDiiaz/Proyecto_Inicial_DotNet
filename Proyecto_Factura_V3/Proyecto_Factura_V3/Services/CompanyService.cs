using AutoMapper;
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
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Company> GetId(int id)
        {
            return await _repository.GetId(id);
        }

        public async Task<List<Company>> GetAll()
        {
            return await _repository.GetAll();
        }


        public async Task<Company> AddEntity(CompanyRequest entity)
        {
            return await _repository.AddEntity(_mapper.Map<Company>(entity));
        }

        public async Task<Company> UpdateEntity(int id, CompanyRequest entity)
        {
            var model = _mapper.Map<Company>(entity);
            model.CompanyId = id;

            return await _repository.UpdateEntity(model);
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

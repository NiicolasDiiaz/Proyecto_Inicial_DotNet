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
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _repository;
        private readonly IMapper _mapper;

        public BranchService(IBranchRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Branch> GetId(int id)
        {
            return await _repository.GetId(id);
        }

        public async Task<List<Branch>> GetAll()
        {
            return await _repository.GetAll();
        }


        public async Task<Branch> AddEntity(BranchRequest entity)
        {
            return await _repository.AddEntity(_mapper.Map<Branch>(entity));
        }

        public async Task<Branch> UpdateEntity(int id, BranchRequest entity)
        {
            var model = _mapper.Map<Branch>(entity);
            model.BranchId = id;

            return await _repository.UpdateEntity(model);
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

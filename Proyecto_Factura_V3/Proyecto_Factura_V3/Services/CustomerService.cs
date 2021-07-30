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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Customer> GetId(int id)
        {
            return await _repository.GetId(id);
        }

        public async Task<List<Customer>> GetAll()
        {
            return await _repository.GetAll();
        }


        public async Task<Customer> AddEntity(CustomerRequest entity)
        {
            return await _repository.AddEntity(_mapper.Map<Customer>(entity));
        }

        public async Task<Customer> UpdateEntity(int id, CustomerRequest entity)
        {
            var model = _mapper.Map<Customer>(entity);
            model.CustomerId = id;

            return await _repository.UpdateEntity(model);
        }


        public async Task DeleteEntity(Customer entity)
        {
            await _repository.DeleteEntity(entity);
        }

        public async Task DeleteId(int id)
        {
            await _repository.DeleteId(id);
        }
    }
}

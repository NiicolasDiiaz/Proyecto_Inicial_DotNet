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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Product> GetId(int id)
        {
            return await _repository.GetId(id);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _repository.GetAll();
        }


        public async Task<Product> AddEntity(ProductRequest entity)
        {
            return await _repository.AddEntity(_mapper.Map<Product>(entity));
        }

        public async Task<Product> UpdateEntity(int id, ProductRequest entity)
        {
            var model = _mapper.Map<Product>(entity);
            model.ProductId = id;

            return await _repository.UpdateEntity(model);
        }


        public async Task DeleteEntity(Product entity)
        {
            await _repository.DeleteEntity(entity);
        }

        public async Task DeleteId(int id)
        {
            await _repository.DeleteId(id);
        }
    }
}

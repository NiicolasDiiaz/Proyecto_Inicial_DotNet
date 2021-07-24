using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product> GetId(int id)
        {
            return await _repository.GetId(id);
        }

        public List<Product> GetAll()
        {
            return _repository.GetAll();
        }


        public async Task<Product> AddEntity(Product entity)
        {
            return await _repository.AddEntity(entity);
        }

        public async Task<Product> UpdateEntity(Product entity)
        {
            return await _repository.UpdateEntity(entity);
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

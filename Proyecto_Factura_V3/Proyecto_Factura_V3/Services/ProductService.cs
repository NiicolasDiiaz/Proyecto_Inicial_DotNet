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
        
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
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
            return await _repository.AddEntity(new Product
            {
                Description = entity.Description,
                Manufacturer = entity.Manufacturer,
                Name = entity.Name,
                UnitPrice = entity.UnitPrice,
                TaxRateId = entity.TaxRateId,
            });
        }

        public async Task<Product> UpdateEntity(int id, ProductRequest entity)
        {
            return await _repository.UpdateEntity(new Product
            {
                ProductId = id,
                Description = entity.Description,
                Manufacturer = entity.Manufacturer,
                Name = entity.Name,
                UnitPrice = entity.UnitPrice,
                TaxRateId = entity.TaxRateId,
            });
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto_Factura_V3.DataAccess;
using Proyecto_Factura_V3.Models;

namespace Proyecto_Factura_V3.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDDBBContext _Context;

        public ProductRepository(IDDBBContext Context)
        {
            _Context = Context;
        }

        public async Task<Product> GetId(int id)
        {
            return await _Context.Products.FindAsync(id);
        }

        public List<Product> GetAll()
        {
            return _Context.Products.Select(x => x).ToList();
        }


        public async Task<Product> AddEntity (Product entity)
        {
            _Context.Products.Add(entity);
            await _Context.SaveChangesAsync();
            return entity;
        }

        public async Task<Product> UpdateEntity(Product entity)
        {
            var model = _Context.Products.Update(entity).Entity;
            await _Context.SaveChangesAsync();
            return model;
        }


        public async Task DeleteEntity(Product entity)
        {
            _Context.Products.Remove(entity);
            await _Context.SaveChangesAsync();
        }

        public async Task DeleteId(int id)
        {
            var model = await GetId(id);
            await DeleteEntity(model);
        }
    }
}

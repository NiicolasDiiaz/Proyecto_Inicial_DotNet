using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto_Factura_V3.DataAccess;
using Proyecto_Factura_V3.Models;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_Factura_V3.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDDBBContext _context;

        public ProductRepository(IDDBBContext context)
        {
            _context = context;
        }

        public async Task<Product> GetId(int id)
        {
            return await _context.Products.Include(x => x.TaxRate).Where(x => x.ProductId == id).FirstOrDefaultAsync();
        }

        public List<Product> GetAll()
        {
            return _context.Products.Include(x => x.TaxRate).Select(x => x).ToList();
        }


        public async Task<Product> AddEntity (Product entity)
        {
            _context.Products.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Product> UpdateEntity(Product entity)
        {
            var model = _context.Products.Update(entity).Entity;
            await _context.SaveChangesAsync();
            return model;
        }


        public async Task DeleteEntity(Product entity)
        {
            _context.Products.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteId(int id)
        {
            var model = await GetId(id);
            await DeleteEntity(model);
        }
    }
}

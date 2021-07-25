using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto_Factura_V3.DataAccess;
using Proyecto_Factura_V3.Models;

namespace Proyecto_Factura_V3.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IDDBBContext _context;

        public CustomerRepository(IDDBBContext context)
        {
            _context = context;
        }

        public async Task<Customer> GetId(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.Select(x => x).ToList();
        }


        public async Task<Customer> AddEntity (Customer entity)
        {
            _context.Customers.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Customer> UpdateEntity(Customer entity)
        {
            var model = _context.Customers.Update(entity).Entity;
            await _context.SaveChangesAsync();
            return model;
        }


        public async Task DeleteEntity(Customer entity)
        {
            _context.Customers.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteId(int id)
        {
            var model = await GetId(id);
            await DeleteEntity(model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto_Factura_V3.DataAccess;
using Proyecto_Factura_V3.Models;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_Factura_V3.Repositories
{
    public class TaxRateRepository : ITaxRateRepository
    {
        private readonly IDDBBContext _context;

        public TaxRateRepository(IDDBBContext context)
        {
            _context = context;
        }

        public async Task<TaxRate> GetId(int id)
        {
            return await _context.TaxRates.Where(x => x.TaxRateId == id).FirstOrDefaultAsync();
        }

        public async Task<List<TaxRate>> GetAll()
        {
            return await _context.TaxRates.Select(x => x).ToListAsync();
        }


        public async Task<TaxRate> AddEntity (TaxRate entity)
        {
            _context.TaxRates.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TaxRate> UpdateEntity(TaxRate entity)
        {
            var model = _context.TaxRates.Update(entity).Entity;
            await _context.SaveChangesAsync();
            return model;
        }


        public async Task DeleteEntity(TaxRate entity)
        {
            _context.TaxRates.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteId(int id)
        {
            var model = await GetId(id);
            await DeleteEntity(model);
        }
    }
}

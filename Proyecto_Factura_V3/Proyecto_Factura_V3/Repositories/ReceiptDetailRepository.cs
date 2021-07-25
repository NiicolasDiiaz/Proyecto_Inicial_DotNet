using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto_Factura_V3.DataAccess;
using Proyecto_Factura_V3.Models;

namespace Proyecto_Factura_V3.Repositories
{
    public class ReceiptDetailRepository : IReceiptDetailRepository
    {
        private readonly IDDBBContext _context;

        public ReceiptDetailRepository(IDDBBContext context)
        {
            _context = context;
        }

        public async Task<ReceiptDetail> GetId(int id)
        {
            return await _context.ReceiptDetails.Include(x => x.Product).Where(x => x.ReceiptDetailId == id).FirstOrDefaultAsync();
        }

        public List<ReceiptDetail> GetAll()
        {
            return _context.ReceiptDetails.Include(x => x.Product).Select(x => x).ToList();
        }


        public async Task<ReceiptDetail> AddEntity (ReceiptDetail entity)
        {
            var product =  await _context.Products.Include(x => x.TaxRate).Where(x => x.ProductId == entity.ProductId).FirstOrDefaultAsync();

            entity.TaxRate = product.TaxRate.Rate;
            entity.UnitValue = product.UnitPrice;
            var preTax = (entity.Quantity * product.UnitPrice);
            entity.TotalValue = preTax + (preTax * product.TaxRate.Rate);

            _context.ReceiptDetails.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<ReceiptDetail> UpdateEntity(ReceiptDetail entity)
        {
            var model = _context.ReceiptDetails.Update(entity).Entity;
            await _context.SaveChangesAsync();
            return model;
        }


        public async Task DeleteEntity(ReceiptDetail entity)
        {
            _context.ReceiptDetails.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteId(int id)
        {
            var model = await GetId(id);
            await DeleteEntity(model);
        }
    }
}

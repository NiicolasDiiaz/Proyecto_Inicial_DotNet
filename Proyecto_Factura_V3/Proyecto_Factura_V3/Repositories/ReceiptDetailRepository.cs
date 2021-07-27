using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto_Factura_V3.DataAccess;
using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using Proyecto_Factura_V3.ViewModels;

namespace Proyecto_Factura_V3.Repositories
{
    public class ReceiptDetailRepository : IReceiptDetailRepository
    {
        private readonly IDDBBContext _context;

        public ReceiptDetailRepository(IDDBBContext context)
        {
            _context = context;
        }
        public async Task<ReceiptDetailView> ViewMapper(ReceiptDetail entity)
        {
            var model = await GetId(entity.ReceiptDetailId);
            return new ReceiptDetailView
            {
                Quantity = model.Quantity,
                ReceiptDetailId = model.ReceiptDetailId,
                TaxRate = model.TaxRate,
                UnitValue = model.UnitValue,
                TotalValue = model.TotalValue,
                Name = model.Product.Name
            };
        }

        public async Task<ReceiptDetail> GetId(int id)
        {
            return await _context.ReceiptDetails.Include(x => x.Product).Where(x => x.ReceiptDetailId == id).FirstOrDefaultAsync();
        }

        public async Task<List<ReceiptDetail>> GetAll()
        {
            return await _context.ReceiptDetails.Include(x => x.Product).Select(x => x).ToListAsync();
        }


        public async Task<ReceiptDetail> AddEntity (ReceiptDetailRequest entity, int receiptHeadId)
        {
            var product =  await _context.Products.Include(x => x.TaxRate).Where(x => x.ProductId == entity.ProductId).FirstOrDefaultAsync();

            var model = _context.ReceiptDetails.Add(new ReceiptDetail
            {
                Quantity = entity.Quantity,
                ProductId = entity.ProductId,
                TaxRate = product.TaxRate.Rate,
                UnitValue = product.UnitPrice,
                TotalValue = (entity.Quantity * product.UnitPrice) + ((entity.Quantity * product.UnitPrice) * product.TaxRate.Rate),
                ReceiptHeadId = receiptHeadId
            }).Entity;
            await _context.SaveChangesAsync();
            return await GetId(model.ReceiptDetailId);
        }

        public async Task<ReceiptDetail> UpdateEntity(ReceiptDetail entity)
        {
            _context.ReceiptDetails.Update(entity);
            await _context.SaveChangesAsync();
            return await GetId(entity.ReceiptDetailId);
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

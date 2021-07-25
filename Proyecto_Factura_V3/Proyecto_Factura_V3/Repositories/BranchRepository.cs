using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto_Factura_V3.DataAccess;
using Proyecto_Factura_V3.Models;

namespace Proyecto_Factura_V3.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        private readonly IDDBBContext _context;

        public BranchRepository(IDDBBContext context)
        {
            _context = context;
        }

        public async Task<Branch> GetId(int id)
        {
            return await _context.Branches.FindAsync(id);
        }

        public List<Branch> GetAll()
        {
            return _context.Branches.Select(x => x).ToList();
        }


        public async Task<Branch> AddEntity (Branch entity)
        {
            _context.Branches.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Branch> UpdateEntity(Branch entity)
        {
            var model = _context.Branches.Update(entity).Entity;
            await _context.SaveChangesAsync();
            return model;
        }


        public async Task DeleteEntity(Branch entity)
        {
            _context.Branches.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteId(int id)
        {
            var model = await GetId(id);
            await DeleteEntity(model);
        }
    }
}

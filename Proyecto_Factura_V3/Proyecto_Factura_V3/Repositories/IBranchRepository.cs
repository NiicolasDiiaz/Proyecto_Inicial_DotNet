using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Repositories
{
    public interface IBranchRepository
    {
        Task<Branch> GetId(int id);
        List<Branch> GetAll();

        Task<Branch> AddEntity(Branch entity);

        Task<Branch> UpdateEntity(Branch entity);

        Task DeleteEntity(Branch entity);
        Task DeleteId(int id);
    }
}

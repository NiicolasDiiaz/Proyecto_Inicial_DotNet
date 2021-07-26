using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public interface IBranchService
    {
        Task<Branch> GetId(int id);
        List<Branch> GetAll();

        Task<Branch> AddEntity(BranchRequest entity);

        Task<Branch> UpdateEntity(int id, BranchRequest entity);

        Task DeleteEntity(Branch entity);
        Task DeleteId(int id);
    }
}

using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Repositories
{
    public interface ICompanyRepository
    {
        Task<Company> GetId(int id);
        Task<List<Company>> GetAll();

        Task<Company> AddEntity(Company entity);

        Task<Company> UpdateEntity(Company entity);

        Task DeleteEntity(Company entity);
        Task DeleteId(int id);
    }
}

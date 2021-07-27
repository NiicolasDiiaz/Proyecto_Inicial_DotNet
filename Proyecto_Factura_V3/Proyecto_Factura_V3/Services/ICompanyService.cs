using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public interface ICompanyService
    {
        Task<Company> GetId(int id);
        Task<List<Company>> GetAll();

        Task<Company> AddEntity(CompanyRequest entity);

        Task<Company> UpdateEntity(int id, CompanyRequest entity);

        Task DeleteEntity(Company entity);
        Task DeleteId(int id);
    }
}

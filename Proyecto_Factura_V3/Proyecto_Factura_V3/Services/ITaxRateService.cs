using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public interface ITaxRateService
    {
        Task<TaxRate> GetId(int id);
        Task<List<TaxRate>> GetAll();

        Task<TaxRate> AddEntity(TaxRateRequest entity);

        Task<TaxRate> UpdateEntity(int id, TaxRateRequest entity);

        Task DeleteEntity(TaxRate entity);
        Task DeleteId(int id);
    }
}

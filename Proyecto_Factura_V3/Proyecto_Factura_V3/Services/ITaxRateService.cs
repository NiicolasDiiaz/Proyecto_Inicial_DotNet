using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public interface ITaxRateService
    {
        Task<TaxRate> GetId(int id);
        List<TaxRate> GetAll();

        Task<TaxRate> AddEntity(TaxRate entity);

        Task<TaxRate> UpdateEntity(TaxRate entity);

        Task DeleteEntity(TaxRate entity);
        Task DeleteId(int id);
    }
}

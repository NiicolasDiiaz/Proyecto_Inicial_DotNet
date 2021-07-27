using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Repositories
{
    public interface IReceiptHeadRepository
    {
        Task<ReceiptHead> GetId(int id);
        Task<List<ReceiptHead>> GetAll();

        Task<ReceiptHead> AddEntity(ReceiptHead entity);

        Task<ReceiptHead> UpdateEntity(ReceiptHead entity);

        Task DeleteEntity(ReceiptHead entity);
        Task DeleteId(int id);
    }
}

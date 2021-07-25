using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Repositories
{
    public interface IReceiptDetailRepository
    {
        Task<ReceiptDetail> GetId(int id);
        List<ReceiptDetail> GetAll();

        Task<ReceiptDetail> AddEntity(ReceiptDetail entity);

        Task<ReceiptDetail> UpdateEntity(ReceiptDetail entity);

        Task DeleteEntity(ReceiptDetail entity);
        Task DeleteId(int id);
    }
}

using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public interface IReceiptDetailService
    {
        Task<ReceiptDetail> GetId(int id);
        List<ReceiptDetail> GetAll();

        Task<ReceiptDetail> AddEntity(ReceiptDetailRequest entity);

        Task<ReceiptDetail> UpdateEntity(ReceiptDetail entity);

        Task DeleteEntity(ReceiptDetail entity);
        Task DeleteId(int id);
    }
}

using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using Proyecto_Factura_V3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Repositories
{
    public interface IReceiptDetailRepository
    {
        Task<ReceiptDetailView> ViewMapper(ReceiptDetail entity);
        Task<ReceiptDetail> GetId(int id);
        Task<List<ReceiptDetail>> GetAll();

        Task<ReceiptDetail> AddEntity(ReceiptDetailRequest entity, int receiptHeadId);

        Task<ReceiptDetail> UpdateEntity(ReceiptDetail entity);

        Task DeleteEntity(ReceiptDetail entity);
        Task DeleteId(int id);
    }
}

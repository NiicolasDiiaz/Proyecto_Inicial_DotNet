using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public interface IReceiptHeadService
    {
        Task<ReceiptHead> GetId(int id);
        List<ReceiptHead> GetAll();

        Task<ReceiptHead> AddEntity(ReceiptHeadRequest entity);

        Task<ReceiptHead> UpdateEntity(ReceiptHead entity);

        Task DeleteEntity(ReceiptHead entity);
        Task DeleteId(int id);
    }
}

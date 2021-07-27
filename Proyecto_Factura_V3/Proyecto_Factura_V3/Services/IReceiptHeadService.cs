using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using Proyecto_Factura_V3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public interface IReceiptHeadService
    {
        Task<ReceiptHeadView> GetId(int id);
        Task<List<ReceiptHeadView>> GetAll();

        Task<ReceiptHeadView> AddEntity(ReceiptHeadRequest entity);

        Task<ReceiptHeadView> UpdateEntity(ReceiptHead entity);

        Task DeleteEntity(ReceiptHead entity);
        Task DeleteId(int id);
    }
}

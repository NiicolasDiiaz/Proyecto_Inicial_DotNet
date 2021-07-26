using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public interface ICustomerService
    {
        Task<Customer> GetId(int id);
        List<Customer> GetAll();

        Task<Customer> AddEntity(CustomerRequest entity);

        Task<Customer> UpdateEntity(int id, CustomerRequest entity);

        Task DeleteEntity(Customer entity);
        Task DeleteId(int id);
    }
}

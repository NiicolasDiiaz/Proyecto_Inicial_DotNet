using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetId(int id);
        List<Customer> GetAll();

        Task<Customer> AddEntity(Customer entity);

        Task<Customer> UpdateEntity(Customer entity);

        Task DeleteEntity(Customer entity);
        Task DeleteId(int id);
    }
}

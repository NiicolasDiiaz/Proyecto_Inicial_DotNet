using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.DataAccess
{
    public interface IDDBBContext
    {

        //Añado DbSet para cada clase. Una tabla por clase. Nombre en plural:
        DbSet<Branch> Branches { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        DbSet<ReceiptHead> ReceiptHeads { get; set; }
        DbSet<TaxRate> TaxRates { get; set; }

        //Metodos de DbContext para materializar los cambios:
        DbSet<TEntity> Set<TEntity>([NotNullAttribute] string name) where TEntity : class;
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        int SaveChanges();

        void RemoveRange([NotNullAttribute] IEnumerable<object> entities);
        EntityEntry Update([NotNullAttribute] object entity);
    }
}

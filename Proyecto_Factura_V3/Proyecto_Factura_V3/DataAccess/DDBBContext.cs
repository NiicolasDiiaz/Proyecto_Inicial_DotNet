using Microsoft.EntityFrameworkCore;
using Proyecto_Factura_V3.EntityConfig;
using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.DataAccess
{
    //Hereda de DbContext y de su interfaz definida
    public class DDBBContext: DbContext, IDDBBContext
    {
        public DDBBContext(DbContextOptions<DDBBContext> options) : base(options)
        {
            //Context configuration from AddDbContext is passed to the DbContext ("options").
        }

        //Añado DbSet para cada clase. Una tabla por clase. Nombre en plural:
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public DbSet<ReceiptHead>  ReceiptHeads { get; set; }
        public DbSet<TaxRate> TaxRates { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Asignar configuraciones entidad principal y otras entidades desde EntityConfig:
            BranchEntityConfig.SetBranchEntityConfig(modelBuilder.Entity<Branch>());
            CompanyEntityConfig.SetCompanyEntityConfig(modelBuilder.Entity<Company>());
            CustomerEntityConfig.SetCustomerEntityConfig(modelBuilder.Entity<Customer>());
            ProductEntityConfig.SetProductEntityConfig(modelBuilder.Entity<Product>());
            ReceiptDetailEntityConfig.SetReceiptDetailEntityConfig(modelBuilder.Entity<ReceiptDetail>());
            ReceiptHeadEntityConfig.SetReceiptHeadEntityConfig(modelBuilder.Entity<ReceiptHead>());
            TaxRateEntityConfig.SetTaxRateEntityConfig(modelBuilder.Entity<TaxRate>());


            //Si se quiere asignar nombre especifico a las tablas, distinto al de la variable DbSet:
            //modelBuilder.Entity<Product>().ToTable("Products")
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
            
        //}
    }
}

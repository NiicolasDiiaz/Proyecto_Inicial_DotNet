using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.EntityConfig
{
    public class ReceiptHeadEntityConfig
    {
        public static void SetReceiptHeadEntityConfig(EntityTypeBuilder<ReceiptHead> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ReceiptHeadId);
            entityBuilder.Property(x => x.CompanyId).IsRequired();
            entityBuilder.Property(x => x.CustomerId).IsRequired();
            entityBuilder.Property(x => x.BranchId).IsRequired();
        }
    }
}

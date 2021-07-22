using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.EntityConfig
{
    public class ReceiptDetailEntityConfig
    {
        public static void SetReceiptDetailEntityConfig(EntityTypeBuilder<ReceiptDetail> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ReceiptDetailId);
            entityBuilder.Property(x => x.ProductId).IsRequired();
        }
    }
}

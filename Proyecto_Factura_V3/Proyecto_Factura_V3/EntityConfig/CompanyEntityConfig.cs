using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.EntityConfig
{
    public class CompanyEntityConfig
    {
        public static void SetCompanyEntityConfig(EntityTypeBuilder<Company> entityBuilder)
        {
            entityBuilder.HasKey(x => x.CompanyId);
            entityBuilder.Property(x => x.Name).IsRequired();
        }
    }
}

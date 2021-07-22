using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Manufacturer { get; set; }

        public double UnitPrice { get; set; }


        public int TaxRateId { get; set; }
        public TaxRate TaxRate { get; set; }
    }
}

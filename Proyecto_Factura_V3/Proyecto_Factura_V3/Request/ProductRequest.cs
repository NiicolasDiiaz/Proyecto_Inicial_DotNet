using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Request
{
    public class ProductRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Manufacturer { get; set; }

        public double UnitPrice { get; set; }


        public int TaxRateId { get; set; }
    }
}

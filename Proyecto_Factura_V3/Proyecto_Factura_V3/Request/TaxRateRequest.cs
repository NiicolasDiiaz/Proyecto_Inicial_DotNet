using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Request
{
    public class TaxRateRequest
    {
        public int Category { get; set; }

        //Rate as a decimal: 0.19 instead of 19
        public double Rate { get; set; }
    }
}

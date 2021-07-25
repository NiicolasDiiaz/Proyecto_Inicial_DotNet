using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Request
{
    public class ReceiptDetailRequest
    {
        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public int ReceiptHeadId { get; set; }
    }
}

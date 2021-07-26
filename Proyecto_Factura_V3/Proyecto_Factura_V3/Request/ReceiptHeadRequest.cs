using Proyecto_Factura_V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Request
{
    public class ReceiptHeadRequest
    {
        public int CustomerId { get; set; }

        public int BranchId { get; set; }

        public List<ReceiptDetailRequest> ReceiptDetails { get; set; }
    }
}

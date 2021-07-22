using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Models
{
    public class Receipt
    {
        public int ReceiptId { get; set; }

        public int ReceiptHeadId { get; set; }
        public ReceiptHead ReceiptHead { get; set; }

        public List<ReceiptDetail> ReceiptDetails { get; set; }
    }
}

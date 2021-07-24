using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Models
{
    public class ReceiptDetail
    {
        public int ReceiptDetailId { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public double UnitValue { get; set; }
        public double TaxRate{ get; set; }

        public double TotalValue { get; set; }

        public int ReceiptId { get; set; }
    }
}

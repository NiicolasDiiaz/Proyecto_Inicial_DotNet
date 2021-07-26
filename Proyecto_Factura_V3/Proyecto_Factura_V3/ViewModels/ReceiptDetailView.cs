using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.ViewModels
{
    public class ReceiptDetailView
    {
        public int ReceiptDetailId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double UnitValue { get; set; }
        public double TaxRate { get; set; }
        public double TotalValue { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.ViewModels
{
    public class ReceiptHeadView
    {
        public int ReceiptHeadId { get; set; }
        public DateTime Date { get; set; }


        public int CustomerId { get; set; }
        public string CustomerName { get; set; }


        public string BranchName { get; set; }
        public int BranchPhone { get; set; }
        public string BranchCity { get; set; }
        public string BranchAddress { get; set; }


        public List<ReceiptDetailView> ReceiptDetails { get; set; }


        public double FinalValue { get; set; }
    }
}

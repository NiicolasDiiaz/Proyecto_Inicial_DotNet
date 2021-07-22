﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Models
{
    public class ReceiptHead
    {
        public int ReceiptHeadId { get; set; }


        public int CompanyId { get; set; }
        public Company Company { get; set; }


        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}

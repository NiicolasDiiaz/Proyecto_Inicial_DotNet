using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Request
{
    public class BranchRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Phone { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public string EmailAddress { get; set; }


        public int CompanyId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Models
{
    public class Company
    {
        public int CompanyId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Nit { get; set; }


        public List<Branch> Branches { get; set; }
    }
}

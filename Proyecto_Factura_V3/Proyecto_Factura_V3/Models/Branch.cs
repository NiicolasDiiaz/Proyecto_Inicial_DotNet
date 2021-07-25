using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Models
{
    public class Branch
    {
        public int BranchId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Phone { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public string EmailAddress { get; set; }


        public int CompanyId { get; set; }
        //No incluir Company o se crea un loop
        //Company tiene branch y a la vez branch tendría  Company(?)!!!!!
        //public Company Company { get; set; }
    }
}

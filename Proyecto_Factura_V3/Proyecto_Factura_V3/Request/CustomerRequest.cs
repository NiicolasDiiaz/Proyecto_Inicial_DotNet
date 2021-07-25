using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Request
{
    public class CustomerRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Cellphone { get; set; }

        public string HomeAddress { get; set; }

        public string EmailAddress { get; set; }
    }
}

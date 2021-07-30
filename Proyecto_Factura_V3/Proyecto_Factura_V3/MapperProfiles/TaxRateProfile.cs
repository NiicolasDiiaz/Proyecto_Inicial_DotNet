using AutoMapper;
using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.MapperProfiles
{
    public class TaxRateProfile : Profile
    {
        public TaxRateProfile()
        {  
            //De TaxRateRequest a TaxRate:
            CreateMap<TaxRateRequest, TaxRate>(); 
        }

    }
}

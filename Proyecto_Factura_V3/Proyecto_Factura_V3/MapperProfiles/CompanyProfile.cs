using AutoMapper;
using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.MapperProfiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {  
            //De request a model:
            CreateMap<CompanyRequest, Company>(); 
        }

    }
}

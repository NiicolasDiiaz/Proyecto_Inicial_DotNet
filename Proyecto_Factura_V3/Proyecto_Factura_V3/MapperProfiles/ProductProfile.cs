using AutoMapper;
using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.MapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {  
            //De request a model:
            CreateMap<ProductRequest, Product>(); 
        }

    }
}

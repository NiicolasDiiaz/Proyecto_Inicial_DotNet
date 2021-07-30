using AutoMapper;
using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.MapperProfiles
{
    public class BranchProfile : Profile
    {
        public BranchProfile()
        {
            //De request a model:
            CreateMap<BranchRequest, Branch>();
        }

    }
}

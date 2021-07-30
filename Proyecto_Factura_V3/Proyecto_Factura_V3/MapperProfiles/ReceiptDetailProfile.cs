using AutoMapper;
using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Request;
using Proyecto_Factura_V3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.MapperProfiles
{
    public class ReceiptDetailProfile : Profile
    {
        public ReceiptDetailProfile()
        {
            //De model a ViewModel:
            //Se necesita una mayor configuracion porque
            //No hay coincidencia directa, "Name" = "Product.Name"
            CreateMap<ReceiptDetail, ReceiptDetailView>()
                .ForMember(dest =>
                dest.Name,
                opt => opt.MapFrom(src => src.Product.Name)
                );

        }

    }
}

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
    public class ReceiptHeadProfile : Profile
    {
        public ReceiptHeadProfile()
        {
            //De model a ViewModel:
            //Se necesita una mayor configuracion 
            CreateMap<ReceiptHead, ReceiptHeadView>()
                .ForMember(dest =>
                    dest.BranchAddress,
                    opt => opt.MapFrom(src => src.Branch.Address)
                )
                .ForMember(dest =>
                    dest.BranchCity,
                    opt => opt.MapFrom(src => src.Branch.City)
                )
                .ForMember(dest =>
                    dest.BranchName,
                    opt => opt.MapFrom(src => src.Branch.Name)
                )
                .ForMember(dest =>
                    dest.BranchPhone,
                    opt => opt.MapFrom(src => src.Branch.Phone)
                )
                .ForMember(dest =>
                    dest.CustomerName,
                    opt => opt.MapFrom(src => src.Customer.FirstName + " " + src.Customer.LastName)
                );    
        }

    }
}

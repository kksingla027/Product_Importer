using AutoMapper;
using Gartner.Product_Importer.Common.DTO;
using Gartner.Product_Importer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gartner.Product_Importer.Business
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}

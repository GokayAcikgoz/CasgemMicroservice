using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDtos;

namespace CasgemMicroservice.Services.Order.Core.Application.Mappings
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<ResultOrderDto, Ordering>().ReverseMap();
            CreateMap<CreateOrderDto, Ordering>().ReverseMap();
            CreateMap<UpdateOrderDto, Ordering>().ReverseMap();
            
        }
    }
}
